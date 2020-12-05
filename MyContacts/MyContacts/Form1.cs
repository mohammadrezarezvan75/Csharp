using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class Form1 : Form
    {
        IContactRepository Repository;
        public Form1()
        {
            InitializeComponent();
            Repository = new ContactRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void BindGrid()
        {
            DgContact.AutoGenerateColumns = false;
            DgContact.DataSource = Repository.SelectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            FrmAddorEdit Frm = new FrmAddorEdit();
            Frm.ShowDialog();
            if (Frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = DgContact.CurrentRow.Cells[1].Value.ToString();
            string family = DgContact.CurrentRow.Cells[2].Value.ToString();
            string fullName = name + " " + family;
            if (DgContact.CurrentRow != null)
            {
                if (MessageBox.Show("آیا از حذف این شخص مطمعن هستید ؟" + fullName, "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int contactid = int.Parse(DgContact.CurrentRow.Cells[0].Value.ToString());
                    Repository.Delete(contactid);
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را از لیست انتخاب کنید");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DgContact.CurrentRow != null)
            {
                int contactid = int.Parse(DgContact.CurrentRow.Cells[0].Value.ToString());
                FrmAddorEdit Frm = new FrmAddorEdit();
                Frm.ContactID = contactid;
                if (Frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DgContact.DataSource = Repository.Search(txtSearch.Text);
        }
    }
}

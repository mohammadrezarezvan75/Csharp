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
    public partial class FrmAddorEdit : Form
    {
        IContactRepository repository;
        public int ContactID = 0;
        public FrmAddorEdit()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }

        bool ValidateInput()
        {

            if (txtName.Text == "")
            {

                MessageBox.Show("لطفا نام را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtFamily.Text == "")
            {

                MessageBox.Show("لطفا نام خانوادگی را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtAge.Value == 0)
            {

                MessageBox.Show("لطفا سن را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMobile.Text == "")
            {

                MessageBox.Show("لطفا موبایل را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtEmail.Text == "")
            {

                MessageBox.Show("لطفا ایمیل را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtAddress.Text == "")
            {

                MessageBox.Show("لطفا آدرس را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                bool isSuccess;
                if (ContactID == 0)
                {
                    isSuccess = repository.Insert(txtName.Text, txtFamily.Text, (int)txtAge.Value, txtMobile.Text, txtEmail.Text, txtAddress.Text);
                }
                else
                {
                    isSuccess = repository.Update(ContactID, txtName.Text, txtFamily.Text, (int)txtAge.Value, txtMobile.Text, txtEmail.Text, txtAddress.Text);

                }
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "تکمیل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void FrmAddorEdit_Load(object sender, EventArgs e)
        {
            if (ContactID == 0)
            {
                this.Text = "فرم مشخصات";
            }
            else
            {
                this.Text = "ویرایش اطلاعات";
                DataTable dt = repository.SelectRow(ContactID);
                txtName.Text = dt.Rows[0][1].ToString();
                txtFamily.Text = dt.Rows[0][2].ToString();
                txtAge.Text = dt.Rows[0][3].ToString();
                txtMobile.Text = dt.Rows[0][4].ToString();
                txtEmail.Text = dt.Rows[0][5].ToString();
                txtAddress.Text = dt.Rows[0][6].ToString();
                btnSubmit.Text = "ویرایش";
            }
        }
    }
}

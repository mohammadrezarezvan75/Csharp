using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWordWithWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != "")
            {
                lblhello.ForeColor = Color.Green;
                lblhello.Text = "Hello !"+" "+ TxtName.Text;
            }
            else
            {
                lblhello.ForeColor = Color.Red;
                lblhello.Text ="Please Enter Name !";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("load");
        }
    }
}

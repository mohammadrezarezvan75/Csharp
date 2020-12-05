using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecetCalculator
{
    public partial class Form1 : Form
    {
        MyCalclutor calclutor;
        public Form1()
        {
            calclutor = new Calculator();
            InitializeComponent();
        }

        bool ValidatInputs()
        {
            bool isValid = true;
            if (txtxNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید ");
            }
            else if (txtNumber2.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد دوم را وارد کنید ");
            }
          
            return isValid;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidatInputs())
            {
                int sum = calclutor.Plus((int)txtxNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show(" sum is :" + sum);
            }
        }

        private void btnMines_Click(object sender, EventArgs e)
        {
            if (ValidatInputs())
            {
                int Mines = calclutor.Mines((int)txtxNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show(" Mines is :" + Mines);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidatInputs())
            {
                int Multiple = calclutor.Multiplay((int)txtxNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show(" Multiple is :" + Multiple);
            }
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            int Div = calclutor.Divid((int)txtxNumber1.Value, (int)txtNumber2.Value);
            MessageBox.Show(" Devid is :" + Div);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

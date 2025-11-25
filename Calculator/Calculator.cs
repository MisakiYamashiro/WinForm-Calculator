using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_number_clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string clickednum = btn.Text;
            tb_mainCalc.Text = tb_mainCalc.Text + clickednum;
        }

        private void btn_fourOperation_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            char[] operations = { '/', 'X', '-', '+' };
            string textbox = tb_mainCalc.Text;
            string btnclicked = btn.Text;
            bool durum = true;
            for (int i = 0; i < textbox.Length; i++)
            {
                for (int j = 0; j < operations.Length; j++)
                {
                    if (textbox[i] == operations[j])
                    {
                        durum = false;
                        break;
                    }
                }
            }
            if (durum==true)
            {
                tb_mainCalc.Text = tb_mainCalc.Text + btnclicked;
            }
            else if (durum==false)
            {

            }
            

            
        }

        private void btn_Equals_Clicked(object sender, EventArgs e)
        {

        }
    }
}

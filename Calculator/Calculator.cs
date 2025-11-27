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
        char[] operations = { '/', 'X', '-', '+', '.' };
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
            string textbox = tb_mainCalc.Text;
            string clickednum = btn.Text;
            if (tb_mainCalc.Text == "0" && clickednum == "0")
            {

            }
            
            if(tb_mainCalc.Text == "0")
            {
                tb_mainCalc.Text = "";
            }
            tb_mainCalc.Text = tb_mainCalc.Text + clickednum;





        }

        private void btn_fourOperation_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            string textbox = tb_mainCalc.Text;
            string btnclicked = btn.Text;
            bool durum = true;
            int sonindex = SonIndexAl(textbox);
            for (int i = 0; i < textbox.Length; i++)
            {
                for (int j = 0; j < operations.Length; j++)
                {
                    
                    if (textbox[sonindex-1] == operations[j])
                    {
                        durum = false;
                        break;
                    }
                    else
                    {
                        durum = true;
                    }
                }
                if (durum == false)
                {
                    break;
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
        private int SonIndexAl(string textbox)
        {
            int sonindex = 0;
            for (int i = 0; i < textbox.Length; i++)
            {
                sonindex++;
            }
            return sonindex;
        }
        private void btn_Equals_Clicked(object sender, EventArgs e)
        {
            try
            {
                string textbox = tb_mainCalc.Text;
                double a = 0;
                string aStr = "";
                string Operator = "";
                double b = 0;
                string bStr = "";
                bool OperatorBuldumMu = false;
                int kaldigimIndex = 0;
                for (int i = 0; i < textbox.Length; i++)
                {
                    OperatorBuldumMu = false;
                    for (int j = 0; j < operations.Length; j++)
                    {
                        if (textbox[i] == operations[j] && textbox[i] != '.')
                        {
                            Operator = textbox[i].ToString();
                            OperatorBuldumMu = true;
                            break;
                        }
                    }
                    if (OperatorBuldumMu == true)
                    {
                        break;
                    }
                    aStr += textbox[i];
                    kaldigimIndex++;
                }
                for (int k = kaldigimIndex + 1 ;k < textbox.Length; k++)
                {
                    bStr += textbox[k];
                }
                a = Convert.ToDouble(aStr);
                b = Convert.ToDouble(bStr);
                string sonucStr = Hesapla(a, Operator, b);
                tb_mainCalc.Text = sonucStr;
            }
            catch (Exception ex){
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private string Hesapla(double a, string Op, double b)
        {
            try
            {
                double sonuc = 0;
                if (Op == "/")
                {
                    sonuc = a / b;
                }
                else if (Op == "X") {
                    sonuc = a * b;
                }
                else if ( Op == "+")
                {
                    sonuc = a + b;
                }
                else if (Op == "-")
                {
                    sonuc = a - b;
                }
                string sonucStr = Convert.ToString(sonuc);
                return sonucStr;
            }

            catch (Exception ex)
            {
                ex.GetBaseException();
                return "Hata";
            }
        }
        private void btn_dotClicked(object sender, EventArgs e)
        {

        }

        private void btn_deleteEverythingClicked(object sender, EventArgs e)
        {
            tb_mainCalc.Text = "0";
        }

        private void btn_deleteClicked(object sender, EventArgs e)
        {
            string textbox = tb_mainCalc.Text;
            int sonindex = SonIndexAl(textbox);
            string enyenitextbox = "";
            for (int i = 0; i < textbox.Length -1 ; i++)
            {
                if (i == sonindex)
                {
                    break;
                }
                enyenitextbox += textbox[i];
                
            }
            if (tb_mainCalc.Text == "")
            {
                tb_mainCalc.Text = "0";
            }
            tb_mainCalc.Text = enyenitextbox;
        }
    }
}

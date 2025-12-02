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
        char[] operations = { '/', 'X', '-', '+', '.', '%' };
        
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

            if (tb_mainCalc.Text == "0")
            {
                tb_mainCalc.Text = "";
            }
            tb_mainCalc.Text = tb_mainCalc.Text + clickednum;





        }
        private void btn_fourOperationChange(bool durum, Button btn)
        {
            string textbox = tb_mainCalc.Text;
            int sonindex = SonIndexAl(textbox) - 1; 
            for (int i = 0; i < textbox.Length; i++)
            {
                for (int k = 0; k < operations.Length; k++)
                {
                    if (textbox[sonindex] == operations[k] && textbox[sonindex] != '.')
                    {
                        string textbox2 = "";
                        for (int j = 0; j < textbox.Length - 1; j++)
                        {
                            
                            if (j == textbox[sonindex])
                            {
                                break;
                            }
                            textbox2 += textbox[j];
                        }
                        tb_mainCalc.Text = textbox2 + btn.Text;
                    }
                }
            }
        }
       
        private void btn_fourOperation_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string textbox = tb_mainCalc.Text;
            int sonindex = textbox.Length - 1;
            bool durum = false;
            if (textbox == "0" && btn.Text == "-")
            {
                textbox = "-";
                return;
            }
            for (int i = 0; i < textbox.Length; i++)
            {
                for (int k = 0; k < operations.Length; k++)
                {
                    if (textbox[sonindex] == operations[k] && textbox[sonindex] != '.')
                    {
                        durum = true;
                        
                    }
                }
            }
            if (durum)
            {
                btn_fourOperationChange(durum, btn); 
            }
            else
            {
                tb_mainCalc.Text = tb_mainCalc.Text + btn.Text;
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
                List<double> numbers = new List<double>();
                List<string> operators = new List<string>();
                string hepsi = "";
                string operatorbulanakadar = "";
                for (int i = 0; i < textbox.Length; i++)
                {
                    bool operatorBuldumMu = false;
                    for (int k = 0; k < operations.Length; k++)
                    {
                        if (textbox[i] == operations[k] && operations[k] != '.')
                        {
                            operators.Add(textbox[i].ToString());
                            hepsi += textbox[i].ToString();
                            operatorBuldumMu = true;
                            break;
                        }
                    }
                    if (operatorBuldumMu)
                    {
                        if (!string.IsNullOrEmpty(operatorbulanakadar))
                        {
                            numbers.Add(Convert.ToDouble(operatorbulanakadar));
                            operatorbulanakadar = "";
                        }
                    }
                    else
                    {
                        operatorbulanakadar += textbox[i];
                        hepsi += textbox[i].ToString();
                    }
                }
                if (!string.IsNullOrEmpty(operatorbulanakadar))
                {
                    numbers.Add(Convert.ToDouble(operatorbulanakadar));
                }
                double sonuc = Hesapla(numbers, operators, textbox, hepsi);
                tb_mainCalc.Text = Convert.ToString(sonuc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private double Hesapla(List<double> number, List<string> operators, string textbox, string hepsi)
        {
            try
            {
                double sonuc = 0;
                
                for (int i = 0; i < operators.Count; i++)
                {
                    if (operators[i] == "X")
                    {
                        sonuc = number[i] * number[i + 1];
                        number[i + 1] = sonuc;
                    }
                    else if (operators[i] == "/")
                    {
                        sonuc = number[i] / number[i + 1];
                        number[i + 1] = sonuc;
                    }
                    else if (operators[i] == "+")
                    {
                        sonuc = number[i] + number[i + 1];
                        number[i + 1] = sonuc;
                    }
                    else if (operators[i] == "-")
                    {
                        sonuc = number[i] - number[i + 1];
                        number[i + 1] = sonuc;
                    }
                    else if (operators[i] == "%")
                    {
                        sonuc = (number[i]*number[i + 1])/ 100 ;
                        number[i + 1] = sonuc;
                    }
                }
                return sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return -1;
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
            for (int i = 0; i < textbox.Length - 1; i++)
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

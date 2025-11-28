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
                //string textbox = tb_mainCalc.Text;
                //double a = 0;
                //string aStr = "";
                //string Operator = "";
                //double b = 0;
                //string bStr = "";
                //bool OperatorBuldumMu = false;
                //int kaldigimIndex = 0;
                //for (int i = 0; i < textbox.Length; i++)
                //{
                //    OperatorBuldumMu = false;
                //    for (int j = 0; j < operations.Length; j++)
                //    {
                //        if (textbox[i] == operations[j] && textbox[i] != '.')
                //        {
                //            Operator = textbox[i].ToString();
                //            OperatorBuldumMu = true;
                //            break;
                //        }
                //    }
                //    if (OperatorBuldumMu == true)
                //    {
                //        break;
                //    }
                //    aStr += textbox[i];
                //    kaldigimIndex++;
                //}
                //for (int k = kaldigimIndex + 1 ;k < textbox.Length; k++)
                //{
                //    bStr += textbox[k];
                //}
                //a = Convert.ToDouble(aStr);
                //b = Convert.ToDouble(bStr);
                //string sonucStr = Hesapla(a, Operator, b);
                //tb_mainCalc.Text = sonucStr;

                string textbox = tb_mainCalc.Text;
                List<double> numbers = new List<double>();
                List<string> operators = new List<string>();               
                string hepsi = "";
                for (int a = 0; a < textbox.Length; a++)
                {
                    string currentNumber = "";
                    string operatorcanimistedi = "";
                    for (int b = 0; b < operations.Length; b++)
                    {
                        bool operatorBuldumMu = false;
                        string op = "";
                        if (textbox[a] == operations[b] && textbox[a] != '.')
                        {
                           op += operations[b];
                           operatorBuldumMu = true;

                        }
                        if (operatorBuldumMu == true)
                        {
                            operators.Add(op);
                            hepsi += op;
                            break;
                        }                        
                    }
                    for (int i = 0; i < operations.Length; i++)
                    {
                        if (textbox[a] == operations[i])
                        {
                           // BU DÖNGÜYÜ DÜZELT TEKRAR BREAKDOWN YAP
                        }
                        else
                        {
                            currentNumber += textbox[a];
                            hepsi += currentNumber;
                        }
                    }
                    
                    numbers.Add(Convert.ToDouble(currentNumber));
                }
                double sonuc = Hesapla(numbers, operators, textbox, hepsi);
                tb_mainCalc.Text = Convert.ToString(sonuc);
            }
            catch (Exception ex){
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private double Hesapla(List<double> number, List<string> operators, string textbox, string hepsi)
        {
            try
            {
                double sonuc = 0;
                for (int i = 0; i < hepsi.Length; i++)
                {
                    double sayi1 = 0;
                    double sayi2 = 0;
                    string ope = "";
                    for (int k = 0; k < number.Count; k++)
                    {
                        for (int l = 0; l < operators.Count; l++)
                        {
                            if (hepsi[i].ToString() == operators[l])
                            {
                                sayi1 = number[k];
                                ope = operators[l];
                                sayi2 = number[k + 1];
                                if (ope == "/")
                                {
                                    sonuc += sayi1 / sayi2;
                                }
                                else if (ope == "X")
                                {
                                    sonuc += sayi1 * sayi2;
                                }
                                else if (ope == "+")
                                {
                                    sonuc += sayi1 + sayi2;
                                }
                                else if (ope == "-")
                                {
                                    sonuc += sayi1 - sayi2;
                                }
                            }
                        }
                    }
                    
                    //for (int j = 0; j < operators.Count; j++)
                    //{
                    //    if (hepsi[i].ToString() == operators[j] )
                    //    {
                    //        string op = "";
                    //        op += hepsi[i];
                    //        if (true)
                    //        {

                    //        }
                    //    }
                    //}
                }
                return sonuc;
                //double sonuc = 0;
                //if (Op == "/")
                //{
                //    sonuc = a / b;
                //}
                //else if (Op == "X") {
                //    sonuc = a * b;
                //}
                //else if ( Op == "+")
                //{
                //    sonuc = a + b;
                //}
                //else if (Op == "-")
                //{
                //    sonuc = a - b;
                //}
                //string sonucStr = Convert.ToString(sonuc);
                //return sonucStr; 
            }

            catch (Exception ex)
            {
                ex.GetBaseException();
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

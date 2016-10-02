using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class Calculator : ContentPage
    {
        double input1;
        string operasi = "";
        
        bool baru = true; //input bil1
        bool first = false; //--> input setelah sama dengan, buat ngeClear lblInput
        bool op = false; //penanda sudah ada operasi yang akan dikerjakan
        
        public Calculator()
        {
            InitializeComponent();
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;
            btn6.Clicked += Btn6_Clicked;
            btn7.Clicked += Btn7_Clicked;
            btn8.Clicked += Btn8_Clicked;
            btn9.Clicked += Btn9_Clicked;
            btn0.Clicked += Btn0_Clicked;
            btntitik.Clicked += Btntitik_Clicked;
            btnTambah.Clicked += BtnTambah_Clicked;
            btnKurang.Clicked += BtnKurang_Clicked;
            btnKali.Clicked += BtnKali_Clicked;
            btnBagi.Clicked += BtnBagi_Clicked;
            btnHasil.Clicked += BtnHasil_Clicked;
            btnPersen.Clicked += BtnPersen_Clicked;
            btnMinus.Clicked += BtnMinus_Clicked;
            btnClear.Clicked += BtnClear_Clicked;
            
        }
        
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            string hasil;
            var panjang = LblInput.Text.Length;
            if (panjang > 0)
            {
                hasil = LblInput.Text.Substring(0, LblInput.Text.Length - 1);
                LblInput.Text = hasil;
            }
            if (baru)
            {
                
                LblInput.Text = "";
                btnClear.Text = "C";
                
            }


        }
        private void BtnMinus_Clicked(object sender, EventArgs e)
        {
            if (LblInput == null)
            {
                DisplayAlert("Warning", "Please enter the number", "OK");
            }
            else
            {
                var tampil = (Convert.ToDouble(LblInput.Text) * (-1)).ToString();
                LblInput.Text = tampil;
            }
        }
        private void BtnPersen_Clicked(object sender, EventArgs e)
        {
            if (LblInput == null)
            { DisplayAlert("Warning", "Please enter the number", "OK"); }
            else
            {
                double angka = double.Parse(LblInput.Text);
                LblInput.Text = (angka / 100).ToString();
            }

        }
        //Hasil
        private void BtnHasil_Clicked(object sender, EventArgs e)
        {
            if (baru)
            { DisplayAlert("Warning", "You haven't input anything", "OK"); }

            double input2 = double.Parse(LblInput.Text);
            double hasil =0;
            double hasil2;
            if (operasi == "+")
                hasil = input1 + input2;
            else if (operasi == "-")
                hasil = input1 - input2;
            else if (operasi == "x")
                hasil = input1 * input2;
            else if (operasi == "/")
            
                hasil = input1 / input2;
                
           
            DisplayAlert("hasil", hasil.ToString(), "OK");
            LblHistory.Text = "";
            hasil2 = Math.Round(hasil, 4);
            if (hasil2.ToString().Length >10)
            {
                hasil2 = Convert.ToDouble(hasil2.ToString().Substring(0, 10));
            }
            LblInput.Text = hasil2.ToString();
            baru = true;
            first = true;
            btnClear.Text = "AC";
            op = false;


        }
        //Operasi Mat
        private void BtnBagi_Clicked(object sender, EventArgs e)
        {
            
            baru = false;
            
            if (op)
                DisplayAlert("Warning", "Please hit the result button", "OK");
            else
            {
                History(LblInput.Text + " ÷ ");
                operasi = "/";
            }
            op = true;
        }
        private void BtnKali_Clicked(object sender, EventArgs e)
        {
            baru = false;
            if (op)
                DisplayAlert("Warning", "Please hit the result button", "OK");
            else
            {
                History(LblInput.Text + " x ");
                operasi = "x";
            }
            op = true;
        }
        private void BtnKurang_Clicked(object sender, EventArgs e)
        {
            baru = false;
            if (op)
                DisplayAlert("Warning", "Please hit the result button", "OK");
            else
            {
                History(LblInput.Text + " - ");
                operasi = "-";
            }
            op = true;
        }
        private void BtnTambah_Clicked(object sender, EventArgs e)
        {
            baru = false;
            if (op)
                DisplayAlert("Warning", "Please hit the result button", "OK");
            else
            {
                History(LblInput.Text + " + ");
                operasi = "+";
            }
            op = true;
        }
        //Angka
        private void Btntitik_Clicked(object sender, EventArgs e)
        {
            LblInput.Text += ".";
        }
        private void Btn9_Clicked(object sender, EventArgs e)
        {
            
            if (first)
            {
                Clear();
            }
            if (CekPenuh()==false)
            {
                LblInput.Text += "9";
            }
            

        }
        private void Btn8_Clicked(object sender, EventArgs e)
        {
           
            if (first)
                Clear();
            if (CekPenuh() == false)
                LblInput.Text += "8";
        }
        private void Btn7_Clicked(object sender, EventArgs e)
        {
            if (first)
            Clear();
            if (CekPenuh() == false)
                LblInput.Text += "7";
        }
        private void Btn6_Clicked(object sender, EventArgs e)
        {
            if (first)
            { Clear(); }
            if (CekPenuh() == false)
                LblInput.Text += "6";
        }
        private void Btn5_Clicked(object sender, EventArgs e)
        {
            if (first)
            { Clear(); }
            if (CekPenuh() == false)
                LblInput.Text += "5";
        }
        private void Btn4_Clicked(object sender, EventArgs e)
        {
            if (first)
            { Clear(); }
            if (CekPenuh() == false)
                LblInput.Text += "4";
        }
        private void Btn3_Clicked(object sender, EventArgs e)
        {
            if (first)
            { Clear(); }
            if (CekPenuh() == false)
                LblInput.Text += "3";
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            if (first)
            { Clear(); }
            if (CekPenuh() == false)
                LblInput.Text += "2";
        }
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (first)
            { Clear(); }
            if (CekPenuh() == false)
                LblInput.Text += "1";
        }
        private void Btn0_Clicked(object sender, EventArgs e)
        {
            if (first)
            { Clear(); }
            if (CekPenuh() == false)
                LblInput.Text += "0";
        }
        private void History(string input)
        {
            input1 = Convert.ToDouble(LblInput.Text);
            LblHistory.Text += input;
            LblInput.Text = "";
        }
        private void Clear()
        {
            LblInput.Text = "";
            first = false;
        }
        private bool CekPenuh()
        {
            if (LblInput.Text.Length == 10)
            {
                DisplayAlert("Warning", "The number has reached its maximum length", "OK");
                return true;
            }
            else
                return false;

        }
        
    }
}

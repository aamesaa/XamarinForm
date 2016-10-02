using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class BMI : ContentPage
    {
        public BMI()
        {
            InitializeComponent();
            List<string> lstGender = new List<string> { "Pria", "Wanita" };
            foreach (var gen in lstGender)
            {
                pickerGender.Items.Add(gen); //<-- Buat nambahin/masukkin data di RadioBtn
            }
            BtnSubmit.Clicked += BtnSubmit_Clicked;
        }

        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            var pil = pickerGender.Items[pickerGender.SelectedIndex];
            double bmi = Convert.ToDouble(Berat.Text) / Math.Pow(Convert.ToDouble(Tinggi.Text),2) ;
            string hasil="";
            if (pil=="Pria")
            {
                if (bmi < 17)
                    hasil = "kurus";
                else if (bmi < 23)
                    hasil = "normal";
                else if (bmi < 27)
                    hasil = "kegemukan";
                else
                    hasil = "obesitas";
            }
            else
            {
                if (bmi < 18)
                    hasil = "kurus";
                else if (bmi < 25)
                    hasil = "normal";
                else if (bmi < 27)
                    hasil = "kegemukan";
                else
                    hasil = "obesitas";
            }
            DisplayAlert("Hasil", "BMI anda : " + bmi + " Anda termasuk " + hasil, "OK");

        }
    }
}

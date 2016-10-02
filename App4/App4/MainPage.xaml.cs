using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //List<string> lstGender = new List<string> { "Pria", "Wanita" };
            //foreach (var gen in lstGender)
            //{
            //    pickerGender.Items.Add(gen); //<-- Buat nambahin/masukkin data di RadioBtn
            //}
            //BtnSubmit.Clicked += BtnSubmit_Clicked;
        }


        private void btnTambah_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(EntryBil1.Text) + Convert.ToInt32(EntryBil2.Text);
            DisplayAlert("Hasil", "Hasil penjumlahannya " + a.ToString(), "OK");
        }
        private void btnKurang_Clicked(object sender, EventArgs e)
        {
            int b = (Convert.ToInt16(EntryBil1.Text)) - (Convert.ToInt16(EntryBil2.Text));
            DisplayAlert("Hasil", "Hasil pengurangannya " + b, "OK");
        }
        private void btnKali_Clicked(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(EntryBil1.Text) * Convert.ToInt32(EntryBil2.Text);
            DisplayAlert("Hasil", "Hasil perkaliannya " + c.ToString(), "OK");
        }
        private void btnBagi_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(EntryBil1.Text) / Convert.ToDouble(EntryBil2.Text);
            DisplayAlert("Hasil", "Hasil pembagiannya " + a.ToString(), "OK");
        }
    }
}

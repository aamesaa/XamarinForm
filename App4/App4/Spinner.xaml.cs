using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class Spinner : ContentPage
    {
        public Spinner()
        {
            InitializeComponent();
            List<string> lstGender = new List<string> { "Pria", "Wanita" };
            foreach (var gen in lstGender)
            {
                pickerGender.Items.Add(gen); //<-- Buat nambahin/masukkin data di RadioBtn
            }
            BtnSubmit.Clicked += btnSubmit_clicked;
            
        }
        private void btnSubmit_clicked(object sender, EventArgs e)
        {
            var pil = pickerGender.Items[ pickerGender.SelectedIndex];
            DisplayAlert("Keterangan", "Anda memilih " + pil, "OK");
        }
    }
}

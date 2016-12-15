using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using App4.Model;
using App4.ViewModel;
using Xamarin.Forms;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System.Collections.ObjectModel;

namespace App4
{
    public partial class JenisPage : ContentPage
    {
        public JenisPage()
        {
            InitializeComponent();
            daftarJns.ItemTapped += DaftarJns_ItemTapped;
            AddJns.Clicked += AddJns_Clicked;

        }

        private void AddJns_Clicked(object sender, EventArgs e)
        {
            JenisAddPage jns = new JenisAddPage();
            Navigation.PushAsync(jns);
        }

        private void DaftarJns_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            JenisMotor item = (JenisMotor)e.Item;
            JenisEditPage edit = new JenisEditPage();
            edit.BindingContext = item;
            Navigation.PushAsync(edit);
        }

        protected override void OnAppearing()
        {
            this.BindingContext = new JenisMotorVM();
        }
    }
}

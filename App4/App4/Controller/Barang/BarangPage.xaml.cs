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
    public partial class BarangPage : ContentPage
    {
        public BarangPage()
        {
            InitializeComponent();
            List<string> lstSearch = new List<string> { "Nama Barang", "Nama Kategori" };
            foreach(var src in lstSearch)
            {
                pickSearch.Items.Add(src);
            }
            daftarBrg.ItemTapped += DaftarBrg_ItemTapped;
            AddBrg.Clicked += AddBrg_Clicked;
            btnSearch.Clicked += BtnSearch_Clicked;
        }

        private void BtnSearch_Clicked(object sender, EventArgs e)
        {
            var pil = pickSearch.Items[pickSearch.SelectedIndex];
            if (pil== "Nama Barang")
            {
                this.BindingContext = new Search(txtCari.Text, "true");
            }
            else if (pil== "Nama Kategori")
            {
                this.BindingContext = new Search(txtCari.Text, "false");
            }
        }

        private void AddBrg_Clicked(object sender, EventArgs e)
        {
            BarangAddPage brg = new BarangAddPage();
            Navigation.PushAsync(brg);
        }

        private void DaftarBrg_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Barang brg = (Barang)e.Item;
            BarangEditPage edit = new BarangEditPage();
            edit.BindingContext = brg;
            Navigation.PushAsync(edit);
        }
        protected override void OnAppearing()
        {
            this.BindingContext = new BarangVM();
        }
    }
}

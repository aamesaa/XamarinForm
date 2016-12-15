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
    public partial class KategoriPage : ContentPage
    {
        public KategoriPage()
        {
            
            InitializeComponent();
            daftarKategori.ItemTapped += DaftarKategori_ItemTapped;
            AddKat.Clicked += AddKat_Clicked;
            //CARI
            //Cari.TextChanged += Cari_TextChanged;
        }
        private RestClient _client =
        new RestClient("http://progmob.azurewebsites.net/");
        //CARI
       

        private void AddKat_Clicked(object sender, EventArgs e)
        {
            KategoriAddPage kat = new KategoriAddPage();
            Navigation.PushAsync(kat);
        }
       
        private void DaftarKategori_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Kategori item = (Kategori)e.Item;
            KategoriEditPage edit = new KategoriEditPage();
            edit.BindingContext = item;
            Navigation.PushAsync(edit);            
        }

        protected override void OnAppearing()
        {
            this.BindingContext = new KategoriVM();
        }
    }
}

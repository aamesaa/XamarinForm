using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Portable;
using App4.Model;
using RestSharp.Portable.HttpClient;
using Xamarin.Forms;

namespace App4
{
    public partial class BarangAddPage : ContentPage
    {
        public BarangAddPage()
        {
            InitializeComponent();
            btnAdd.Clicked += BtnAdd_Clicked;
        }
        private RestClient _client =
         new RestClient("http://progmob.azurewebsites.net/");

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/barang", Method.POST);
            var baru = new Barang
            {
               KodeBarang=txtKodeBrg.Text,
                IdJenisMotor = Convert.ToInt32(TxtIdJns.Text),
                KategoriID = Convert.ToInt32(txtKategoryId.Text),
                Nama = txtNama.Text,
                Stok = Convert.ToInt32(txtStok.Text),
                HargaBeli = Convert.ToInt32(txtHargaBeli.Text),
                HargaJual = Convert.ToInt32(txtHargaJual.Text),
                TglBeli = TglBeli.Date
                
            };
            _request.AddBody(baru);
            try
            {
                var _response = await _client.Execute(_request);
                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await Navigation.PushAsync(new BarangPage());
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", "Error : " + ex.Message, "OK");
            }
        }
    }
}

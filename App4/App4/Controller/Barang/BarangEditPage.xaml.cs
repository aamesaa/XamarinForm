using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App4.Model;
using RestSharp.Portable.HttpClient;
using RestSharp.Portable;
using Xamarin.Forms;

namespace App4
{
    public partial class BarangEditPage : ContentPage
    {
        public BarangEditPage()
        {
            InitializeComponent();
            btnEdit.Clicked += BtnEdit_Clicked;
            btnDelete.Clicked += BtnDelete_Clicked;
        }

        private RestClient _client =
      new RestClient("http://progmob.azurewebsites.net/");
        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/Barang/{id}", Method.DELETE);
            _request.AddParameter("id", txtKodeBrg.Text);
            try
            {
                var _response = await _client.Execute(_request);
                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await Navigation.PopAsync();
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", "Error : " + ex.Message, "OK");
            }
        }

        private async void BtnEdit_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/barang", Method.PUT);
            var baru = new Barang
            {
                KodeBarang = txtKodeBrg.Text,
                IdJenisMotor = Convert.ToInt32(TxtIdJns.Text),
                HargaBeli = Convert.ToInt32(txtHargaBeli.Text),
                HargaJual = Convert.ToInt32(txtHargaJual.Text),
                KategoriID = Convert.ToInt32(txtKategoryId.Text),
                Stok = Convert.ToInt32(txtStok.Text),
                TglBeli = TglBeli.Date,
                Nama=txtNama.Text
            };

            _request.AddBody(baru);
            try
            {
                var _response = await _client.Execute(_request);
                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await Navigation.PopAsync();
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", "Error : " + ex.Message, "OK");
            }
        }
    }
}

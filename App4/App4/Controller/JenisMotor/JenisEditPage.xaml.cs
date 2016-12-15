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
    public partial class JenisEditPage : ContentPage
    {
        public JenisEditPage()
        {
            InitializeComponent();
            btnDelete.Clicked += BtnDelete_Clicked;
            btnEdit.Clicked += BtnEdit_Clicked;
        }
        private RestClient _client =
          new RestClient("http://progmob.azurewebsites.net/");

        private async void BtnEdit_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/jenisMotor", Method.PUT);
            var baru = new JenisMotor
            {
                IdJnsMotor=Convert.ToInt32(txtId.Text),
                NamaJenisMotor = txtNama.Text,
                NamaMerk = txtNamaMerk.Text
            };
            _request.AddBody(baru);
            try
            {
                var _response = await _client.Execute(_request);
                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await Navigation.PushAsync(new JenisPage());
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Error : " + ex.Message, "OK");
            }
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/jenisMotor/{id}", Method.DELETE);
            _request.AddParameter("id", txtId.Text);
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

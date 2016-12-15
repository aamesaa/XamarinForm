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
    public partial class JenisAddPage : ContentPage
    {
        public JenisAddPage()
        {
            InitializeComponent();
            btnAdd.Clicked += BtnAdd_Clicked;
        }
        private RestClient _client =
         new RestClient("http://progmob.azurewebsites.net/");
        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/jenisMotor", Method.POST);
            var baru = new JenisMotor
            {
                
                NamaJenisMotor = txtNamaJns.Text,
                NamaMerk = txtMerk.Text
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
    }
}

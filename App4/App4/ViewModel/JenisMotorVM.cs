using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using Xamarin.Forms;
using App4.Model;
using App4.ViewModel;
using RestSharp;
using RestSharp.Portable.HttpClient;
using RestSharp.Portable;

namespace App4.ViewModel
{
    public class JenisMotorVM : BindableObject
    {
        private RestClient _client =
           new RestClient("http://progmob.azurewebsites.net/");
        private ObservableCollection<JenisMotor> daftarjnsMotor_;

        public ObservableCollection<JenisMotor> daftarJnsMotor
        {
            get { return daftarjnsMotor_; }
            set { daftarjnsMotor_ = value; OnPropertyChanged("daftarJnsMotor"); }
        }
        private async void RefreshDataAsync()
        {
            RestRequest _request = new RestRequest("api/jenisMotor", Method.GET);
            var _response = await _client.Execute<List<JenisMotor>>(_request);
            daftarJnsMotor = new ObservableCollection<JenisMotor>(_response.Data);
        }
        public JenisMotorVM()
        {
            RefreshDataAsync();
        }

    }
}

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
   public class BarangVM : BindableObject
    {
        private RestClient _client =
            new RestClient("http://progmob.azurewebsites.net/");

        private ObservableCollection<Barang> daftarBrg_;

        public ObservableCollection<Barang> daftarBrg
        {
            get { return daftarBrg_; }
            set { daftarBrg_ = value; OnPropertyChanged("daftarBrg"); }
        }

        private async  void RefreshData()
        {
            RestRequest _request = new RestRequest("api/barang", Method.GET);
            var _response = await _client.Execute<List<Barang>>(_request);
            daftarBrg = new ObservableCollection<Barang>(_response.Data);
        }

        public BarangVM()
        {
            RefreshData();
        }
    }
}

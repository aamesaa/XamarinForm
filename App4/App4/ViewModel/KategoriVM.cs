using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using App4.Model;
using App4.ViewModel;
using RestSharp;
using RestSharp.Portable.HttpClient;
using RestSharp.Portable;

namespace App4.ViewModel
{
    public class KategoriVM : BindableObject
    {
        private RestClient _client = 
            new RestClient("http://progmob.azurewebsites.net/");

        private ObservableCollection<Kategori> listKategori_;
        public ObservableCollection<Kategori> listKategori
        {
            get { return listKategori_; }
            set { listKategori_ = value; OnPropertyChanged("listKategori"); }
        }
        private async void RefreshDataAsync()
        {
            RestRequest _request = new RestRequest("api/kategori", Method.GET);
            var _response = await _client.Execute<List<Kategori>>(_request);
            listKategori = new ObservableCollection<Kategori>(_response.Data);

        }
        public KategoriVM()
        {
            RefreshDataAsync();
        }
       

    }
    
}

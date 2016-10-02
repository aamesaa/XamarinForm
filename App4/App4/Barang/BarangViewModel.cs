using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace App4
{
    class BarangViewModel : BindableObject
    {
        private List<ModelBarang> daftarBarang_;
        public List<ModelBarang> daftarBarang
        {
            get { return daftarBarang_; }
            set          
            {
                daftarBarang_ = value;
                OnPropertyChanged("daftarBarang");
            }
        }
        public BarangViewModel()
        {
            daftarBarang_ = new List<ModelBarang>
            {
                new ModelBarang {kodeBarang="A01",namaBarang="Buku Tulis",hrgBeli=600,hrgJual=1000,stok=30,foto="foto1.jpg" },
                new ModelBarang {kodeBarang="A02",namaBarang="Buku Gambar",hrgBeli=1600,hrgJual=2000,stok =80,foto="foto2.jpg"}
            };
        }
    }
}

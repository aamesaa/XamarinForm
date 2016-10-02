using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class ModelBarang
    { //KodeBarang, NamaBarang, Stok, HargaJual,HargaBeli
        public string foto { get; set; }
        private string kodeBarang_;
        public string kodeBarang
        {
            get { return kodeBarang_; }
            set { kodeBarang_ = value; }
        }
        private string namaBarang_;
        public string namaBarang
        {
            get { return namaBarang_; }
            set { namaBarang_ = value; }
        }

        private int stok_;
        public int stok
        {
            get { return stok_; }
            set { stok_ = value; }
        }

        private int hrgJual_;
        public int hrgJual
        {
            get { return hrgJual_; }
            set { hrgJual_ = value; }
        }

        private int hrgBeli_;
        public int hrgBeli
        {
            get { return hrgBeli_; }
            set { hrgBeli_ = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class BindingBarang : ContentPage
    {
        public BindingBarang()
        {
            InitializeComponent();
            BindingContext = new BarangViewModel();
          
            //listBarang.ItemSelected += ListBarang_ItemSelected;
        }

        private void ListBarang_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var result = (ModelBarang)e.SelectedItem;
            DisplayAlert("Ket", "stok" + result.stok.ToString() + "\n hrg jual " + result.hrgJual.ToString() + "\n hrg beli " + result.hrgBeli.ToString(), "OK");
        }

      
    }
}

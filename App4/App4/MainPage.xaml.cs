using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App4.Model;
namespace App4
{
    /**
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //btnTambah.Clicked += btnTambah_Clicked;
            // btnKali.Clicked += btnKali_Clicked;
            // btnBagi.Clicked += btnBagi_Clicked;
            // btnKurang.Clicked += btnKurang_Clicked;
            //DisplayAlert("Welcome", "hello", "OK");

        }
        private void btnTambah_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(EntryBil1.Text) + Convert.ToInt32(EntryBil2.Text);
            DisplayAlert("Hasil", a.ToString(), "OK");
        }
        private void btnKurang_Clicked(object sender, EventArgs e)
        {
            int b = (Convert.ToInt16(EntryBil1.Text)) - (Convert.ToInt16(EntryBil2.Text));
            DisplayAlert("Hasil", "Hasilnya" + b, "OK");
        }
        private void btnKali_Clicked(Object sender, EventArgs e)
        {
            int c = Convert.ToInt32(EntryBil1.Text) * Convert.ToInt32(EntryBil2.Text);
            DisplayAlert("Hasil", c.ToString(), "OK");
        }
        private void btnBagi_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(EntryBil1) / Convert.ToInt32(EntryBil2);
            DisplayAlert("Hasil", a.ToString(), "OK");
        }
    }
}
**/
public partial class MainPage : MasterDetailPage
{
    public MainPage()
    {
        InitializeComponent();
        var item = new List<MasterPageItem>();
        item.Add(new MasterPageItem{ Title = "Barang", TargetType = typeof(BarangPage) });
        item.Add(new MasterPageItem{ Title = "Kategori", TargetType = typeof(KategoriPage) });
        item.Add(new MasterPageItem{ Title = "Jenis", TargetType = typeof(JenisPage) });
        
        navDarwerList.ItemsSource = item;
        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(KategoriPage)));
        navDarwerList.ItemSelected += NavDarwerList_ItemSelected;
    }

    private void NavDarwerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var item = (MasterPageItem)e.SelectedItem;
        Type page = item.TargetType;
        Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        IsPresented = false;
    }

    
}
}


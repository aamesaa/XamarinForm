using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class List : ContentPage
    {
        public List()
        {
            InitializeComponent();
            List<string> items =
                new List<string> { "Android Studio", "Visual Studio", "VS Code" };
            lstView.ItemsSource = items;
            lstView.ItemTapped += LstView_ItemTapped;
        }

        private void LstView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Caution", "You chose" + e.Item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}

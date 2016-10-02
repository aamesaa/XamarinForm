using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class Lat1 : ContentPage
    {

        public Lat1()
        {
            InitializeComponent();
            var options = new List<string> { "Ana", "Bana", "Cana", "Dana" };
            foreach (var nama in options)
                { picker.Items.Add(nama); }
            picker.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                pageValue.Text = picker.Items[picker.SelectedIndex];
            };
            datePicker.DateSelected += DatePicker_DateSelected;
            timePicker.PropertyChanged += TimePicker_PropertyChanged;
            stepper.ValueChanged += Stepper_ValueChanged;
            slide.ValueChanged += Slide_ValueChanged;
            @switch.Toggled += switch_Toggled;
        }

        private void switch_Toggled(object sender, ToggledEventArgs e)
        {
            eventValue.Text = string.Format("Switch is now {0}", e.Value);
            pageValue.Text = @switch.IsToggled.ToString();
        }

        private void Slide_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }   
}

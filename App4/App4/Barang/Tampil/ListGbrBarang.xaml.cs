﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class ListGbrBarang : ContentPage
    {
        public ListGbrBarang()
        {
            InitializeComponent();
            BindingContext = new BarangViewModel();

        }
    }
}
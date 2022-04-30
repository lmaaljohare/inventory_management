﻿using inventory_management.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace inventory_management.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProduct : ContentPage
    {
        public AddProduct()
        {

            InitializeComponent();
            BindingContext = new AddProducViewModel();

        }
    }
}
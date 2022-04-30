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
    public partial class ShowProduct : ContentPage
    {
        public ShowProduct()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            this.BindingContext = new ShowProductViewModel();
        }
    }
}
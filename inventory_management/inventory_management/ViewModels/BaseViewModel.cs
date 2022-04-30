using inventory_management.Services;
using Inventory_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace inventory_management.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public Product _product;
        public IProductRepository _productRepository;
        public AddProducViewModel _addProducView;

        public AddProducViewModel _addProducViewModel;

        public string Name
        {
            get => _product.Name;
            set
            {
                _product.Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string BarCode
        {
            get => _product.BarCode;
            set
            {
                _product.BarCode = _addProducViewModel.BarCodeReaded;
                NotifyPropertyChanged("BarCode");
            }
        }



        public DateTime Date
        {
            get => _product.Date;
            set
            {
                _product.Date = DateTime.Today;
                NotifyPropertyChanged("Date");
            }
        }



        private List<Product> _productList;
        public List<Product> ProductList
        {
            get => _productList;
            set
            {
                _productList = value;
                NotifyPropertyChanged("ProductList");
            }
        }

        #region INotifyPropertyChanged      
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}


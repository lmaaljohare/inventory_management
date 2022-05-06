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
        public History _history;

        public Product _product;
        public IProductRepository _productRepository;
        public AddItemViewModel _addItemViewModel;
        // public AddItemViewModel AddItemViewModel=new AddItemViewModel(_product.IdProduct);

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
                _product.BarCode = value;
                NotifyPropertyChanged("BarCode");
            }
        }



        public DateTime CreatedAt
        {
            get => _product.CreatedAt;
            set
            {
                _product.CreatedAt = DateTime.Now;
                NotifyPropertyChanged("CreatedAt");
            }
        }
        public double Price
        {
            get => _product.Price;
            set
            {

                _product.Price = value;
                NotifyPropertyChanged("Price");
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




        //   public decimal TotalQuantity => _history.Quantity;

        #region INotifyPropertyChanged      
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}


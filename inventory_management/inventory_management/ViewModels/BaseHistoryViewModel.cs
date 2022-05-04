using inventory_management.Services;
using Inventory_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace inventory_management.ViewModels
{
    public class BaseHistoryViewModel : INotifyPropertyChanged
    {
        public History _history;
        public IHistoryRepository _historyRepository;
        public Product _product;
        public IProductRepository _productRepository;

        public string HistoryName
        {
            get => _history.Name;
            set
            {
                _history.Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public int Quantity
        {
            get => _history.Quantity;
            set
            {
                _history.Quantity = value;
                NotifyPropertyChanged("Quantity");
            }
        }



        public DateTime Date
        {
            get => _history.Date;
            set
            {
                _history.Date = DateTime.Today;
                NotifyPropertyChanged("Date");
            }
        }



        private List<History> _historyList;

        public List<History> HistorytList
        {
            get => _historyList;
            set
            {
                _historyList = value;
                NotifyPropertyChanged("HistorytList");
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

using inventory_management.Services;
using inventory_management.Views;
using Inventory_management.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace inventory_management.ViewModels
{
    public class AddItemViewModel : BaseHistoryViewModel
    {

        public ICommand AddItemsCommand { get; private set; }
        public ICommand ViewAllitemCommand { get; private set; }

        public AddItemViewModel(int selectedId)
        {

            _history = new History();
            _historyRepository = new HistoryRepository();
            _product = new Product();
            _product.IdProduct = selectedId;
            AddItemsCommand = new Command(async () => await AddItemProduct());
            ViewAllitemCommand = new Command(async () => await ShowitemList());
            FetchProduct();
            HistorytList = _historyRepository.GetHistorys();

        }




        async Task AddItemProduct()
        {
            _historyRepository.AddQuantity(Quantity, _product.IdProduct);
            await App.Current.MainPage.Navigation.PushAsync(new ShowProduct());
        }
        async Task ShowitemList()
        {

            await App.Current.MainPage.Navigation.PushAsync(new ShowProduct());
        }
        void FetchProduct()
        {
            HistorytList = _historyRepository.GetHistorys();
        }


        /* public double QTySum()
         {
             return HistorytList.Sum(item => item.Quantity);
         }*/
        private ObservableCollection<History> _history1;

        public ObservableCollection<History> History
        {
            get { return _history1; }
            set
            {

                _history1 = value; NotifyPropertyChanged();

            }

        }
        public double QTySum()
        {

            double total = HistorytList.Sum(item => item.Quantity);

            return total;

            //string total = HistorytList.Select(a => new { Converted = Convert.ToDouble(a.Quantity.Replace("$", "")) }).ToList().Sum(a => a.Converted).ToString("#,0.00");

            //var  anonymousList = HistorytList.GroupBy(p => p.IdHistory).Select(g => new { id = g.Key, totalQuantity = g.Sum(p => p.Quantity) }).ToList();
        }
    }
}
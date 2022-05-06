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


        public AddItemViewModel()
        {

            _history = new History();
            _historyRepository = new HistoryRepository();
            AddItemsCommand = new Command(async () => await AddItemProduct());




        }


        async Task AddItemProduct()
        {
            _historyRepository.AddQuantity(_history);
            await App.Current.MainPage.Navigation.PushAsync(new ShowProduct());
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
            return History.Sum(item => item.Quantity);
        }
    }
}
using inventory_management.Services;
using inventory_management.Views;
using Inventory_management.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace inventory_management.ViewModels
{
    public class ShowProductViewModel : BaseViewModel
    {

        public ICommand AddCommand { get; private set; }
        public ICommand AddItemCommand { get; private set; }

        public ShowProductViewModel()
        {

            _productRepository = new ProductRepository();

            AddCommand = new Command(async () => await ShowAddProduct());
            //  AddItemCommand= new Command(async () => await ShowAddItem());

            FetchProduct();
        }

        void FetchProduct()
        {
            ProductList = _productRepository.GetAllProduct();
        }

        async Task ShowAddProduct()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddProduct());

        }

        async void ShowAddItem()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddItem());

        }

        //   async void ShowProductDetails(int selectedProductId)
        //   {
        //     await App.Current.MainPage.Navigation.PushAsync(new DetailsPage(selectedProductId));
        // }

        private Product _selectedProductItem;
        public Product SelectedProductItem
        {
            get => _selectedProductItem;
            set
            {
                if (value != null)
                {
                    _selectedProductItem = value;
                    NotifyPropertyChanged("SelectedProdutItem");
                    ShowAddItem();
                }
            }
        }
    }
}

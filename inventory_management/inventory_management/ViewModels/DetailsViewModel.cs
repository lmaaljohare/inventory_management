using inventory_management.Services;
using Inventory_management.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
/*
namespace inventory_management.ViewModels
{
        public class DetailsViewModel : BaseViewModel
        {

            public ICommand UpdateProductCommand { get; private set; }
            public ICommand DeleteProductCommand { get; private set; }

            public DetailsViewModel( int selectedId)
            {
             public History _history;
        public IHistoryRepository _historyRepository;


             _product = new Product();
                _product.IdProduct = selectedProductId;
                _productRepository = new ProductRepository();

                UpdateProductCommand = new Command(async () => await UpdateProduct());
                DeleteProductCommand = new Command(async () => await DeletProduct());

              FetchProductDetails();
            }

            void FetchProductDetails()
            {
            _product = _productRepository.GetProductData(_product.IdProduct);
            }

            async Task UpdateProduct()
            {

                   _productRepository.UpdateProduct(_product);
                   await App.Current.MainPage.Navigation.PopAsync();
                    }
                
             
            

            async Task DeletProduct()
            {
                _productRepository.DeleteProduct(_product.IdProduct);
            await App.Current.MainPage.Navigation.PopAsync();
        }
            }
        }

*/
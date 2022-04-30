
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using Inventory_management.Models;
using inventory_management.Services;
using inventory_management.Views;

namespace inventory_management.ViewModels
{
    public class AddProducViewModel : BaseViewModel
    {
        public ICommand AddProductCommand { get; private set; }
        public ICommand ViewAllProductCommand { get; private set; }

        public string BarCodeReaded { get; private set; }


        public ICommand ScanBarcode { get; private set; }

        public AddProducViewModel()
        {

            BarCodeReaded = "";
            ScanBarcode = new Command(async () => await ExecuteScanBarcode());
          
            _product = new Product();
            _productRepository = new ProductRepository();
            AddProductCommand = new Command(async () => await AddProduct());
            ViewAllProductCommand = new Command(async () => await ShowProductList());
        }
        async Task AddProduct()
        {
            _productRepository.AddProduct(_product);
            await App.Current.MainPage.Navigation.PushAsync(new ShowProduct());
        }

        async Task ShowProductList()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ShowProduct());
        }

        public bool IsViewAll => _productRepository.GetAllProduct().Count > 0 ? true : false;
 
            private async Task ExecuteScanBarcode()
        {
#if         __ANDROID__
	            Initialize the scanner first so it can track the current context
	        
#endif


            var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            var result = await scanner.Scan();

            if (result != null)
                //Console.WriteLine("Scanned Barcode: " + result.Text);
                BarCodeReaded = result.Text;
        }
    }
}
using Inventory_management.Data;
using Inventory_management.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_management.Services
{
    public class ProductRepository : IProductRepository
    {

        ProductDataBase _productDataBase;
        public ProductRepository()
        {
            _productDataBase = new ProductDataBase();
        }


        public void DeleteProduct(int id)
        {
            _productDataBase.DeleteProduct(id);

        }

        public List<Product> GetAllProduct()
        {
            return (List<Product>)_productDataBase.GetAllProduct();

        }

        public Product GetProductData(int id)
        {
            return _productDataBase.GetProductData(id);
        }

        public void AddProduct(Product product)
        {
            _productDataBase.AddProduct(product);
        }


        public void UpdateProduct(Product product)
        {
            _productDataBase.UpdateProduct(product);
        }
    }
}

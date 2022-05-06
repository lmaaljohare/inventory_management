using Inventory_management.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_management.Services
{
    public interface IProductRepository
    {
        List<Product> GetAllProduct();

        Product GetProductData(int id);

        void DeleteProduct(int id);

        void AddProduct(Product product);

        void UpdateProduct(Product product);
    }
}

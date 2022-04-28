using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Inventory_management.Models;
using Inventory_management.InterFace;
using Xamarin.Forms;
using System.Linq;
using System;

namespace Inventory_management.Data
{
    public class ProductDataBase
    {

        private readonly SQLiteConnection _sqlconnection;
        public ProductDataBase()
        {
            _sqlconnection = DependencyService.Get<IDatabase>().GetConnection();
            _sqlconnection.CreateTable<Product>();

        }


        public IList<Product> GetProduct()
            => _sqlconnection.Table<Product>().ToList();


        public void AddProduct(Product Product)
        {

            _sqlconnection.Insert(Product);

        }

        public void UpdateProduct(Product Product)
        {
            if (Product.IdProduct != 0)
            {

                _sqlconnection.Update(Product);
            }
            else
            {
                _sqlconnection.Insert(Product);
            }
        }
        public void DeleteProduct(int id)
        {
            _sqlconnection.Delete<Product>(id);
        }




        /* public Task<Product> GetNoteAsync(int id)
         {
             // Get a specific note.
             return database.Table<Product>()
                             .Where(i => i.ID == id)
                             .FirstOrDefaultAsync();
         }


         public Task<int> SaveNoteAsync(Note note)
         {
             if (note.ID != 0)
             {  
                 // Update an existing note.
                 return database.UpdateAsync(note);
             }
             else
             {
                 // Save a new note.
                 return database.InsertAsync(note);
             }
         }

         public Task<int> DeleteNoteAsync(Note note)
         {
             // Delete a note.
             return database.DeleteAsync(note);
         }*/
    }
}
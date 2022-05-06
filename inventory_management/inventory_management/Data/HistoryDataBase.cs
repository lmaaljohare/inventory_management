using Inventory_management.InterFace;
using Inventory_management.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Inventory_management.Data
{
    public class HistoryDataBase
    {
        private readonly SQLiteConnection _sqlconnection;
        public HistoryDataBase()
        {
            _sqlconnection = DependencyService.Get<IDatabase>().GetConnection();
            _sqlconnection.CreateTable<History>();

        }


        public IList<History> GetHistorys()
            => _sqlconnection.Table<History>().ToList();


        public void AddQuantity(double qty, int id)
        {

            _sqlconnection.Insert(new History()
            {
                IdProduct = id,
                Quantity = qty,
                UpdatedAt = DateTime.Now,
            });
        }
        public List<History> SumQuantity()
        {
            return _sqlconnection.Query<History>(" SELECT SUM(Quantity) as sum_quantity FROM [History] GROUP BY IdProduct").ToList();
        }


        public History GetHistoryData(int id)
        {
            return _sqlconnection.Table<History>().FirstOrDefault(t => t.IdProduct == id);
            //   SELECT salesRecord.primaryKey, SUM(SalesRecProdQty) FROM SalesRecord WHERE date(SalesRecDate) BETWEEN date('" +   tbxCDPFrom.Text + "') AND date('" + tbxCDPTo.Text + "')

        }


    }
}

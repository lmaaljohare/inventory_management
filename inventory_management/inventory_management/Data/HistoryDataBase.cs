using Inventory_management.InterFace;
using Inventory_management.Models;
using SQLite;
using System;
using System.Collections.Generic;
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


        public void AddQuantity(History history)
        {

<<<<<<< HEAD

            _ = _sqlconnection.Insert(history);
=======
            _sqlconnection.Insert(history);
>>>>>>> 163a026fb41c3efc8cf790f95b2acc7adbc7f1ad

        }


        public History GetHistoryData(int id)
        {
            return _sqlconnection.Table<History>().FirstOrDefault(t => t.IdProduct == id);
            //   SELECT salesRecord.primaryKey, SUM(SalesRecProdQty) FROM SalesRecord WHERE date(SalesRecDate) BETWEEN date('" +   tbxCDPFrom.Text + "') AND date('" + tbxCDPTo.Text + "')

        }


    }
}

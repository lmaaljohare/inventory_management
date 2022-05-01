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


            _ = _sqlconnection.Insert(history);

        }




    }
}

using Inventory_management.Data;
using Inventory_management.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_management.Services
{
    public class HistoryRepository : IHistoryRepository
    {

        HistoryDataBase _historyDataBase;
        public HistoryRepository()
        {
            _historyDataBase = new HistoryDataBase();
        }



        public List<History> GetHistorys()
        {
            return (List<History>)_historyDataBase.GetHistorys();

        }

        public History GetHistoryData(int id)
        {
            return _historyDataBase.GetHistoryData(id);
        }

        public void AddQuantity(double qty, int id)
        {
            _historyDataBase.AddQuantity(qty, id);
        }
        public List<History> SumQuantity()
        {


            return (List<History>)_historyDataBase.SumQuantity();
        }


    }

}

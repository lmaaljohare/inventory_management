using Inventory_management.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_management.Services
{
    public interface IHistoryRepository
    {
        List<History> GetHistorys();

        History GetHistoryData(int id);

        void AddQuantity(double qty, int id);
        List<History> SumQuantity();

    }
}

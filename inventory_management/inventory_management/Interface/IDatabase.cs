using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_management.InterFace
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}

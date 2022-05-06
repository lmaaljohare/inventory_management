using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace inventory_management.ViewModels
{
    internal class ReportViewModel
    {

        private static System.Data.DataTable GetDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("#", typeof(int));
            dt.Columns.Add("Seq. Num", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Amount", typeof(int));



            return dt;
        }
    }
}

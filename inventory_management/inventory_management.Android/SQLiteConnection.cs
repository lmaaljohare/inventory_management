using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Inventory_management.InterFace;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(Inventory_management.Droid.SQLiteConnection))]
namespace Inventory_management.Droid
{
    class SQLiteConnection : IDatabase
    {
        public SQLite.SQLiteConnection GetConnection()
        {
            var filename = "Product3.db";
            var documentspath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}

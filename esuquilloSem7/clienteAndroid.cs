
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using esuquilloSem7;

[assembly:Xamarin.Forms.Dependency(typeof(clienteAndroid))]

namespace esuquilloSem7
{
    public class clienteAndroid : DataBase
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var rutaBase = Path.Combine(ruta,"uisrael.db3");
            return new SQLiteAsyncConnection(rutaBase);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Elaborare_orarii_profesori.Clase
{
    class Database
    {
        public SQLiteConnection myConnection;
        public Database() {
            this.myConnection = new SQLiteConnection("Data Source=database.db");
            if (!File.Exists("./database.db")) {
                SQLiteConnection.CreateFile("database.db");
                
            }
            
        }
    }
}

using System;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    internal class Sql {
        public string sqlfile, connectionString = null;
        public static SQLiteConnection sqldb = null;
        public static SQLiteCommand sqlcmd = null;
        public static SQLiteDataReader sqlreader = null;
        public Sql(string sqlfile) {
            string dbfile = AppDomain.CurrentDomain.BaseDirectory + sqlfile;
            if (!File.Exists(sqlfile))
            {
                MessageBox.Show("Die Datenbank '" + sqlfile + "' ist leider nicht vorhanden.");
            }
            else
            {
                connectionString = "Data Source=" + dbfile + ";Version=3;";
            }
        }
        public SQLiteDataReader ReadCmd(string cmd)
        {
            sqldb = new SQLiteConnection(this.connectionString);
            sqldb.Open();
            sqlcmd = sqldb.CreateCommand();
            sqlcmd.CommandText = cmd;
            sqlreader = sqlcmd.ExecuteReader();
            return sqlreader;
        }
        public void CloseDb()
        {
            sqldb.Close();
        }
    }
}

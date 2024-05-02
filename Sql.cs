using System;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        public SQLiteDataReader SqlSend(string cmd)
        {
            sqldb = new SQLiteConnection(this.connectionString);
            sqldb.Open();
            sqlcmd = sqldb.CreateCommand();
            sqlcmd.CommandText = SQLEscape(cmd);
            sqlreader = sqlcmd.ExecuteReader();
            return sqlreader;
        }
        public static string SQLEscape(string sqlcmd)
        {
            // Escape: r, n, x00, x1a, Backslash
            if (sqlcmd == null) return null;
            else return Regex.Replace(sqlcmd, @"[rnx00x1a\'""]", @"$0").Replace("EXEC", "");
        }
        public void CloseDb()
        {
            sqldb.Close();
        }
    }
}

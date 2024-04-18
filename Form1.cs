using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.IO;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string dbfile = AppDomain.CurrentDomain.BaseDirectory + "test.db3";
            SQLiteConnection sqldb;
            SQLiteCommand sqlcmd = null;
            SQLiteDataReader sqlreader = null;
            String OutputText = "";

            if (!File.Exists(dbfile))
            {
                MessageBox.Show("Die Datenbank'" + dbfile + "'ist leider nicht vorhanden.");
            }
            else
            {
                string connectionString = "Data Source=" + dbfile + ";Version=3;";
                sqldb = new SQLiteConnection(connectionString);
                sqldb.Open();
                sqlcmd = sqldb.CreateCommand();
                sqlcmd.CommandText = "SELECT * FROM tbl_land";
                sqlreader = sqlcmd.ExecuteReader();
                while (sqlreader.Read())
                {
                    // optional auch auslesen mit sqlreader.GetValue(0);
                    OutputText += sqlreader["ID"].ToString() + " '" + sqlreader["Name"].ToString() + "' " + "\n";
                }
                MessageBox.Show(OutputText);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}

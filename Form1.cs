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
using System.Security.Cryptography;

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
                List<Laender> laenderauswahl = new List<Laender>();
                while (sqlreader.Read())
                {
                    // optional auch auslesen mit sqlreader.GetValue(0);
                    // OutputText += sqlreader["ID"].ToString() + " '" + sqlreader["Name"].ToString() + "' " + "\n";
                    string tmid;
                    if (sqlreader["Tm_Id"] is null)
                    {
                        tmid = "null";
                    }
                    else
                    {
                        tmid = (string)sqlreader.GetString(7);
                    }
                    laenderauswahl.Add(new Laender() { Id = sqlreader.GetInt32(0), Name = sqlreader.GetString(1), Name2 = sqlreader.GetString(2), Einwohner = sqlreader.GetDouble(3), Hauptstadt = sqlreader.GetString(4), Fahne = sqlreader.GetString(5), Tm_Id = tmid });
                }
                cbolaender.DataSource = laenderauswahl;
                cbolaender.ValueMember = "Id";
                cbolaender.DisplayMember = "Name";  
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void cbolaender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Laender objLand = cbolaender.SelectedItem as Laender;
            if(objLand != null)
                txtboxlandname.Text = objLand.Name.ToString();
                txtboxlandeinwohner.Text = objLand.Einwohner.ToString();
                txtboxenglish.Text = objLand.Name2.ToString();
                txtboxfahne.Text = objLand.Fahne.ToString();
                txtboxhauptstadt.Text = objLand.Hauptstadt.ToString();
                txtboxfifapunkte.Text = objLand.FifaPunkte.ToString();
                txtboxtransfermarktid.Text =objLand.Tm_Id.ToString();
        }

        private void cbolaender_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void lbllandeinwohner_Click(object sender, EventArgs e)
        {

        }
    }
}

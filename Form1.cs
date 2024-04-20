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
using System.Diagnostics;
//using static System.Net.WebRequestMethods;
using System.Net.NetworkInformation;

namespace Editor
{
    public partial class Form1 : Form
    {   
        // SQLite DB vorbereitungen für die Events
        public static string dbfile = AppDomain.CurrentDomain.BaseDirectory + "test.db3";
        public static string connectionString = "Data Source=" + dbfile + ";Version=3;";
        public static SQLiteConnection sqldb;
        public static SQLiteCommand sqlcmd = null;
        public static SQLiteDataReader sqlreader = null;

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
            if (!File.Exists(dbfile))
            {
                MessageBox.Show("Die Datenbank '" + dbfile + "' ist leider nicht vorhanden.");
            }
            else
            {
                sqldb = new SQLiteConnection(connectionString);
                sqldb.Open();
                sqlcmd = sqldb.CreateCommand();
                sqlcmd.CommandText = "SELECT * FROM tbl_land";
                sqlreader = sqlcmd.ExecuteReader();
                List<Laender> laenderauswahl = new List<Laender>();
                while (sqlreader.Read())
                {
                    string tmid;
                    if (sqlreader["Tm_Id"] is null)
                    {
                        tmid = "9999";
                    }
                    else
                    {
                        tmid = (sqlreader["Tm_Id"].ToString() == null) ? string.Empty : sqlreader["Tm_Id"].ToString();
                    }
                    laenderauswahl.Add(new Laender() { Id = sqlreader.GetInt32(0), Name = sqlreader.GetString(1), Name2 = sqlreader.GetString(2), Einwohner = sqlreader.GetDouble(3), Hauptstadt = sqlreader.GetString(4), Fahne = sqlreader.GetString(5), FifaPunkte = sqlreader.GetInt32(6), Tm_Id = tmid });
                }
                sqldb.Close();
                cbolaender.DataSource = laenderauswahl;
                cbolaender.ValueMember = "Id";
                cbolaender.DisplayMember = "Name";  
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // speichert alles
        }

        private void cbolaender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Laender objLand = cbolaender.SelectedItem as Laender;
            if(objLand != null)
                txtboxlandid.Text = objLand.Id.ToString();
                txtboxlandname.Text = objLand.Name.ToString();
                txtboxlandeinwohner.Text = objLand.Einwohner.ToString();
                txtboxenglish.Text = objLand.Name2.ToString();
                picboxfahne.Load(objLand.Fahne.ToString());
                txtboxfahne.Text = objLand.Fahne.ToString();
                txtboxhauptstadt.Text = objLand.Hauptstadt.ToString();
                txtboxfifapunkte.Text = objLand.FifaPunkte.ToString();
                txtboxtransfermarktid.Text =objLand.Tm_Id.ToString();

            sqldb = new SQLiteConnection(connectionString);
            sqldb.Open();
            sqlcmd = null;
            sqlcmd = sqldb.CreateCommand();
            sqlcmd.CommandText = "SELECT * FROM tbl_ligen WHERE Land_ID = " + objLand.Id.ToString();
            sqlreader = sqlcmd.ExecuteReader();
            List<Ligen> ligenauswahl = new List<Ligen>();
            while (sqlreader.Read())
            {
                ligenauswahl.Add(new Ligen() { Id = sqlreader.GetInt32(0), Land_Id = sqlreader.GetInt32(1), Rang = sqlreader.GetInt32(2), Name = sqlreader.GetString(3), Groesse = sqlreader.GetInt32(4), BildURL = sqlreader.GetString(5), Tm_Link = sqlreader.GetString(6), LandURL = objLand.Fahne });
            }
            sqldb.Close(); 
            cboligen.DataSource = ligenauswahl;
            cboligen.ValueMember = "Id";
            cboligen.DisplayMember = "Name";

        }

        private void cboligaauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ligen objLiga = cboligen.SelectedItem as Ligen;
            if(objLiga != null)
            {
                txtboxliganame.Text = objLiga.Name.ToString();
                txtboxligarang.Text = objLiga.Rang.ToString();
                txtboxligagroesse.Text = objLiga.Groesse.ToString();
                picboxliga.Load(objLiga.BildURL.ToString());
                txtboxligalogo.Text = objLiga.BildURL.ToString();
                picboxligaland.Load(objLiga.LandURL.ToString());
                txtboxligaland.Text = objLiga.Land_Id.ToString();
                txtboxligatransfermarktid.Text = objLiga.Tm_Link.ToString();
            }
        }
    }
}

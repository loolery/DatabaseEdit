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
        Sql sqldbcaller = new Sql("test.db3");
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
            sqlreader = sqldbcaller.ReadCmd("SELECT * FROM tbl_land");
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
            sqldbcaller.CloseDb();    
            cbolaender.DataSource = laenderauswahl;    
            cbolaender.ValueMember = "Id";    
            cbolaender.DisplayMember = "Name";      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // speichert alles
        }

        private void cbolaender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Laender objLand = cbolaender.SelectedItem as Laender;
            if (objLand != null)
            {
                txtboxlandid.Text = objLand.Id.ToString();
                txtboxlandname.Text = objLand.Name.ToString();
                txtboxlandeinwohner.Text = objLand.Einwohner.ToString();
                txtboxenglish.Text = objLand.Name2.ToString();
                picboxfahne.Load(objLand.Fahne.ToString());
                txtboxfahne.Text = objLand.Fahne.ToString();
                txtboxhauptstadt.Text = objLand.Hauptstadt.ToString();
                txtboxfifapunkte.Text = objLand.FifaPunkte.ToString();
                txtboxtransfermarktid.Text = objLand.Tm_Id.ToString();
            }
            sqlreader = sqldbcaller.ReadCmd("SELECT * FROM tbl_ligen WHERE Land_ID = " + objLand.Id.ToString());
            List<Ligen> ligenauswahl = new List<Ligen>();
            while (sqlreader.Read())
            {
                ligenauswahl.Add(new Ligen() { Id = sqlreader.GetInt32(0), Land_Id = sqlreader.GetInt32(1), Rang = sqlreader.GetInt32(2), Name = sqlreader.GetString(3), Groesse = sqlreader.GetInt32(4), BildURL = sqlreader.GetString(5), Tm_Link = sqlreader.GetString(6), LandURL = objLand.Fahne });
            }
            sqldbcaller.CloseDb();
            cboligen.DataSource = ligenauswahl;
            cboligen.ValueMember = "Id";
            cboligen.DisplayMember = "Name";

        }

        private void cboligaauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ligen objLiga = cboligen.SelectedItem as Ligen;
            if (objLiga != null)
            {
                txtboxligaid.Text = objLiga.Id.ToString();
                txtboxliganame.Text = objLiga.Name.ToString();
                txtboxligarang.Text = objLiga.Rang.ToString();
                txtboxligagroesse.Text = objLiga.Groesse.ToString();
                picboxligalogo.Load(objLiga.BildURL.ToString());
                txtboxligalogo.Text = objLiga.BildURL.ToString();
                picboxligaland.Load(objLiga.LandURL.ToString());
                txtboxligaland.Text = objLiga.Land_Id.ToString();
                txtboxligatransfermarktid.Text = objLiga.Tm_Link.ToString();
            }
            sqlreader = sqldbcaller.ReadCmd("SELECT * FROM tbl_vereine WHERE Liga_ID = " + objLiga.Id.ToString());
            List<Vereine> vereinsauswahl = new List<Vereine>();
            while (sqlreader.Read())
            {
                vereinsauswahl.Add(new Vereine() { Id = sqlreader.GetInt32(0), Stadt_Id = sqlreader.GetInt32(1), Liga_Id = sqlreader.GetInt32(2), Name = sqlreader.GetString(3), Tabellenplatz = sqlreader.GetInt32(4), Gruendung = sqlreader.GetString(5), Farben = sqlreader.GetString(6), Stadionname = sqlreader.GetString(7), Transfermarktid = sqlreader.GetInt32(8), Geld = sqlreader.GetDouble(9) });
            }
            sqldbcaller.CloseDb();
            cbovereine.DataSource = vereinsauswahl;
            cbovereine.ValueMember = "Id";
            cbovereine.DisplayMember = "Name";
        }
        private void cbovereinsauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vereine objVerein = cbovereine.SelectedItem as Vereine;
            if (objVerein != null)
            {
                txtboxvereinid.Text = objVerein.Id.ToString();
                txtboxvereinstadtid.Text = objVerein.Stadt_Id.ToString();
                txtboxvereinligaid.Text = objVerein.Liga_Id.ToString();
                txtboxvereintransfermarktid.Text = objVerein.Transfermarktid.ToString();
                txtboxvereinname.Text = objVerein.Name.ToString();
                txtboxvereintabellenplatz.Text = objVerein.Tabellenplatz.ToString();
                txtboxvereingruendung.Text = objVerein.Gruendung.ToString();
                txtboxvereinfarben.Text = objVerein.Farben.ToString();
                txtboxvereinstadionname.Text = objVerein.Stadionname.ToString();
                txtboxvereingeld.Text = objVerein.Geld.ToString();
            }
            sqlreader = sqldbcaller.ReadCmd("SELECT * FROM tbl_personen WHERE Verein_ID = " + objVerein.Id.ToString());
            List<Spieler> spielerauswahl = new List<Spieler>();
            while (sqlreader.Read())
            {
                spielerauswahl.Add(new Spieler() { Id = sqlreader.GetInt32(0), Land_Id = sqlreader.GetInt32(1), Verein_Id = sqlreader.GetInt32(2), Trikotnr = sqlreader.GetInt32(3), Vorname = sqlreader.GetString(4), Nachname = sqlreader.GetString(5), Geburtstag = (string)sqlreader[6], Groesse = sqlreader.GetInt32(7), Fuss = sqlreader.GetInt32(8), Foto = sqlreader.GetString(9), Technik = sqlreader.GetInt32(19), Einsatz = sqlreader.GetInt32(20), Schnelligkeit = sqlreader.GetInt32(21)  });
            }
            sqldbcaller.CloseDb();
            cbospieler.DataSource = spielerauswahl;
            cbospieler.ValueMember = "Id";
            cbospieler.DisplayMember = "Name";
        }

        private void cboxspieler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Spieler objSpieler = cbospieler.SelectedItem as Spieler;
            if (objSpieler != null)
            {
                txtboxspielerid.Text = objSpieler.Id.ToString();
                txtboxspielerlandid.Text = objSpieler.Land_Id.ToString();
                txtboxspielervereinid.Text = objSpieler.Verein_Id.ToString();
                txtboxspielertrikotnr.Text = objSpieler.Trikotnr.ToString();
                txtboxspielervorname.Text = objSpieler.Vorname.ToString();
                txtboxspielernachname.Text = objSpieler.Nachname.ToString();
                txtboxspielergeburtstag.Text = objSpieler.Geburtstag.ToString();
                txtboxspielergroesse.Text = objSpieler.Groesse.ToString();
                txtboxspielerfuss.Text = objSpieler.Fuss.ToString();
                picboxspielerbild.Load(objSpieler.Foto.ToString());
                txtboxspielerbild.Text = objSpieler.Foto.ToString();
                txtboxspielertechnik.Text = objSpieler.Technik.ToString();
                txtboxspielereinsatz.Text = objSpieler.Einsatz.ToString();
                txtboxspielerschnelligkeit.Text = objSpieler.Schnelligkeit.ToString();
            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }
    }
}

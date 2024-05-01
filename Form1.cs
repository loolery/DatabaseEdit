using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Threading;

namespace Editor
{
    public partial class Form1 : Form
    {
        // SQLite DB load
        Sql sqldbcaller = new Sql("test.db3");
        public static SQLiteDataReader sqlreader = null;
        public int filecounter = 0;

        public Form1()
        {
            InitializeComponent();
            pbarstatusstrip.Maximum = 100;
            pbarstatusstrip.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            filecounter = 0;
            pbarstatusstrip.Show();
            pbarstatusstrip.Value = 1;
            sqlreader = sqldbcaller.SqlSend("SELECT * FROM tbl_land");
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
            Thread.Sleep(50);
            pbarstatusstrip.Value = 20;
        }

        private void cbolaender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Laender objLand = cbolaender.SelectedItem as Laender;
            if (objLand != null)
            {
                txtboxlandid.Text = objLand.Id.ToString();
                txtboxlandname.Text = objLand.Name.ToString();
                txtboxlandeinwohner.Text = objLand.Einwohner.ToString();
                txtboxlandenglish.Text = objLand.Name2.ToString();
                picboxfahne.Load(objLand.Fahne.ToString());
                txtboxlandfahne.Text = objLand.Fahne.ToString();
                txtboxlandhauptstadt.Text = objLand.Hauptstadt.ToString();
                txtboxlandfifapunkte.Text = objLand.FifaPunkte.ToString();
                txtboxlandtransfermarktid.Text = objLand.Tm_Id.ToString();
            }
            sqlreader = sqldbcaller.SqlSend("SELECT * FROM tbl_ligen WHERE Land_ID = " + objLand.Id.ToString());
            List<Ligen> ligenauswahl = new List<Ligen>();
            while (sqlreader.Read())
            {
                ligenauswahl.Add(new Ligen() { Id = sqlreader.GetInt32(0), Land_Id = sqlreader.GetInt32(1), Rang = sqlreader.GetInt32(2), Name = sqlreader.GetString(3), Groesse = sqlreader.GetInt32(4), BildURL = sqlreader.GetString(5), Tm_Link = sqlreader.GetString(6), LandURL = objLand.Fahne });
            }
            sqldbcaller.CloseDb();
            cboligen.DataSource = ligenauswahl;
            cboligen.ValueMember = "Id";
            cboligen.DisplayMember = "Name";
            if (filecounter == 0)
            {
                Thread.Sleep(50);
                pbarstatusstrip.Value = 40;
            }

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
            sqlreader = sqldbcaller.SqlSend("SELECT * FROM tbl_vereine WHERE Liga_ID = " + objLiga.Id.ToString());
            List<Vereine> vereinsauswahl = new List<Vereine>();
            while (sqlreader.Read())
            {
                vereinsauswahl.Add(new Vereine() { Id = sqlreader.GetInt32(0), Stadt_Id = sqlreader.GetInt32(1), Liga_Id = sqlreader.GetInt32(2), Name = sqlreader.GetString(3), Tabellenplatz = sqlreader.GetInt32(4), Gruendung = sqlreader.GetString(5), Farben = sqlreader.GetString(6), Stadionname = sqlreader.GetString(7), Stadionplaetze = sqlreader.GetInt32(8), Transfermarktid = sqlreader.GetInt32(9), Geld = sqlreader.GetDouble(10) });
            }
            sqldbcaller.CloseDb();
            cbovereine.DataSource = vereinsauswahl;
            cbovereine.ValueMember = "Id";
            cbovereine.DisplayMember = "Name";
            if (filecounter == 0)
            {
                Thread.Sleep(50);
                pbarstatusstrip.Value = 60;
            }
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
                txtboxvereinstadionplaetze.Text = objVerein.Stadionplaetze.ToString();
                txtboxvereingeld.Text = objVerein.Geld.ToString();
            }
            sqlreader = sqldbcaller.SqlSend("SELECT * FROM tbl_personen WHERE Verein_ID = " + objVerein.Id.ToString());
            List<Spieler> spielerauswahl = new List<Spieler>();
            while (sqlreader.Read())
            {
                spielerauswahl.Add(new Spieler() { Id = sqlreader.GetInt32(0), Land_Id = sqlreader.GetInt32(1), Verein_Id = sqlreader.GetInt32(2), Trikotnr = sqlreader.GetInt32(3), Vorname = sqlreader.GetString(4), Nachname = sqlreader.GetString(5), Geburtstag = (string)sqlreader[6], Groesse = sqlreader.GetInt32(7), Fuss = sqlreader.GetInt32(8), Foto = sqlreader.GetString(9), Marktwert = sqlreader.GetDouble(16), Technik = sqlreader.GetInt32(19), Einsatz = sqlreader.GetInt32(20), Schnelligkeit = sqlreader.GetInt32(21)  });
            }
            sqldbcaller.CloseDb();
            cbospieler.DataSource = spielerauswahl;
            cbospieler.ValueMember = "Id";
            cbospieler.DisplayMember = "Name";
            if (filecounter == 0)
            {
                Thread.Sleep(50);
                pbarstatusstrip.Value = 80;
            }
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
                if (objSpieler.Foto.ToString() == "https://i.seadn.io/gae/PTIvyNEFSwpiBA-Kv7ZTRNGzBOOxMzIW59q5vX02Ml911J4_Y5UwfooDhE6oQrULV0M5YODgqWkr6W4o19bxLY2qXCJuDhJ8Y4uObg")
                {
                    picboxspielerbild.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxspielerbild.Load("https://karriere.ottcomputer.de/images/contact-persons/60586cbd0a28c_nopic.png");
                    txtboxspielerbild.Text = "https://karriere.ottcomputer.de/images/contact-persons/60586cbd0a28c_nopic.png";
                } else
                {
                    picboxspielerbild.SizeMode = PictureBoxSizeMode.AutoSize;
                    picboxspielerbild.Load(objSpieler.Foto.ToString());
                    txtboxspielerbild.Text = objSpieler.Foto.ToString();
                }
                txtboxspielermarktwert.Text = objSpieler.Marktwert.ToString();
                txtboxspielertechnik.Text = objSpieler.Technik.ToString();
                txtboxspielereinsatz.Text = objSpieler.Einsatz.ToString();
                txtboxspielerschnelligkeit.Text = objSpieler.Schnelligkeit.ToString();      
                
                if(filecounter == 0) 
                {
                    pbarstatusstrip.Value = 100;
                    Thread.Sleep(50);
                    pbarstatusstrip.Hide();
                    filecounter += 1;
                }
            }
        }
        private void txtboxspieler_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlcmd;
            // Save the countrydata's in db
            int cid = Convert.ToInt32(txtboxlandid.Text);
            string cname = txtboxlandname.Text;
            string cname2 = txtboxlandenglish.Text;
            double einwohner = Convert.ToDouble(txtboxlandeinwohner.Text);
            string hauptstadt = txtboxlandhauptstadt.Text;
            string fahne = txtboxlandfahne.Text;
            int fifapunkte = Convert.ToInt32(txtboxlandfifapunkte.Text);
            string ctransfermarktid = txtboxlandtransfermarktid.Text;
            sqlcmd = "UPDATE tbl_land SET Name = '" + cname + "', Name2 = '" + cname2 + "', Einwohner = " + einwohner + ", Hauptstadt = '" + hauptstadt + "', Fahne = '" + fahne + "', FifaPunkte = " + fifapunkte + ", Tm_Id = " + ctransfermarktid + " WHERE ID=" + cid;
            sqldbcaller.SqlSend(sqlcmd);
            sqlcmd = null;
            //// Save the seasondata's in db
            int lid = Convert.ToInt32(txtboxligaid.Text);
            string sname = txtboxliganame.Text;
            int rang = Convert.ToInt32(txtboxligarang.Text);
            int lgroesse = Convert.ToInt32(txtboxligagroesse.Text);
            string logo = txtboxligalogo.Text;
            int ligaland = Convert.ToInt32(txtboxligaland.Text);
            string transfermarktid = txtboxligatransfermarktid.Text;
            sqlcmd = "UPDATE tbl_ligen SET Name = '" + sname + "', Rang = " + rang + ", Groesse = " + lgroesse + ", BildURL = '" + logo + "', Land_ID = " + ligaland + ", Tm_Link = '" + transfermarktid + "' WHERE ID=" + lid;
            sqldbcaller.SqlSend(sqlcmd);
            sqlcmd = null;
            // Save the teamdata's in db
            int tid = Convert.ToInt32(txtboxvereinid.Text);
            string tname = txtboxvereinname.Text;
            int tabellenplatz = Convert.ToInt32(txtboxvereintabellenplatz.Text);
            string gruendung = txtboxvereingruendung.Text;
            string farben = txtboxvereinfarben.Text;
            string stadion = txtboxvereinstadionname.Text;
            int stadionplaetze = Convert.ToInt32(txtboxvereinstadionplaetze.Text);
            int geld = Convert.ToInt32(txtboxvereingeld.Text);
            sqlcmd = "UPDATE tbl_vereine SET Name = '" + tname + "', Tabellenplatz = " + tabellenplatz + ", Gruendung = '" + gruendung + "', Vereinsfarben = '" + farben + "', Stadion = '" + stadion + "', Stadionplaetze = " + stadionplaetze + ", Geld = " + geld + " WHERE ID=" + tid;
            sqldbcaller.SqlSend(sqlcmd);
            sqlcmd = null;
            // Save the playerdata's in db
            int pid = Convert.ToInt32(txtboxspielerid.Text);
            string vorname = txtboxspielervorname.Text;
            string nachname = txtboxspielernachname.Text;
            string geburtstag = txtboxspielergeburtstag.Text;
            int groesse = Convert.ToInt32(txtboxspielergroesse.Text);
            int fuss = Convert.ToInt32(txtboxspielerfuss.Text);
            string bild = txtboxspielerbild.Text;
            int marktwert = Convert.ToInt32(txtboxspielermarktwert.Text);
            int technik = Convert.ToInt32(txtboxspielertechnik.Text);
            int einsatz = Convert.ToInt32(txtboxspielereinsatz.Text);
            int schnelligkeit = Convert.ToInt32(txtboxspielerschnelligkeit.Text);
            sqlcmd = "UPDATE tbl_personen SET Vorname = '" + vorname + "', Nachname = '" + nachname + "', Geburtsdatum = '" + geburtstag + "', Groesse = " + groesse + ", Fuss = " + fuss + ", Foto = '" + bild + "', Marktwert = " + marktwert + ", Technik = " + technik + ", Einsatz = " + einsatz + ", Schnelligkeit = " + schnelligkeit + " WHERE ID=" + pid;
            sqldbcaller.SqlSend(sqlcmd);
            
            sqldbcaller.CloseDb();
            btnSave.Enabled = false;
        }

    }
}

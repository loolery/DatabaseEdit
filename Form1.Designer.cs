﻿namespace Editor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxlandeinwohner = new System.Windows.Forms.TextBox();
            this.lbllandeinwohner = new System.Windows.Forms.Label();
            this.txtboxlandname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbolaender = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboligaauswahl = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtboxenglish = new System.Windows.Forms.TextBox();
            this.lblname2 = new System.Windows.Forms.Label();
            this.lblhauptstadt = new System.Windows.Forms.Label();
            this.txtboxhauptstadt = new System.Windows.Forms.TextBox();
            this.txtboxfahne = new System.Windows.Forms.TextBox();
            this.txtboxfifapunkte = new System.Windows.Forms.TextBox();
            this.txtboxtransfermarktid = new System.Windows.Forms.TextBox();
            this.lblfahne = new System.Windows.Forms.Label();
            this.lblfifapunkte = new System.Windows.Forms.Label();
            this.lbltranfermarktid = new System.Windows.Forms.Label();
            this.picboxfahne = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxfahne)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen...";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.infoToolStripMenuItem.Text = "Info?";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.überToolStripMenuItem.Text = "Über...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picboxfahne);
            this.groupBox1.Controls.Add(this.lbltranfermarktid);
            this.groupBox1.Controls.Add(this.lblfifapunkte);
            this.groupBox1.Controls.Add(this.lblfahne);
            this.groupBox1.Controls.Add(this.txtboxtransfermarktid);
            this.groupBox1.Controls.Add(this.txtboxfifapunkte);
            this.groupBox1.Controls.Add(this.txtboxfahne);
            this.groupBox1.Controls.Add(this.txtboxhauptstadt);
            this.groupBox1.Controls.Add(this.lblhauptstadt);
            this.groupBox1.Controls.Add(this.lblname2);
            this.groupBox1.Controls.Add(this.txtboxenglish);
            this.groupBox1.Controls.Add(this.txtboxlandeinwohner);
            this.groupBox1.Controls.Add(this.lbllandeinwohner);
            this.groupBox1.Controls.Add(this.txtboxlandname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Länder Daten:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtboxlandeinwohner
            // 
            this.txtboxlandeinwohner.Location = new System.Drawing.Point(73, 74);
            this.txtboxlandeinwohner.Name = "txtboxlandeinwohner";
            this.txtboxlandeinwohner.Size = new System.Drawing.Size(165, 20);
            this.txtboxlandeinwohner.TabIndex = 3;
            // 
            // lbllandeinwohner
            // 
            this.lbllandeinwohner.AutoSize = true;
            this.lbllandeinwohner.Location = new System.Drawing.Point(7, 80);
            this.lbllandeinwohner.Name = "lbllandeinwohner";
            this.lbllandeinwohner.Size = new System.Drawing.Size(60, 13);
            this.lbllandeinwohner.TabIndex = 2;
            this.lbllandeinwohner.Text = "Einwohner:";
            this.lbllandeinwohner.Click += new System.EventHandler(this.lbllandeinwohner_Click);
            // 
            // txtboxlandname
            // 
            this.txtboxlandname.Location = new System.Drawing.Point(73, 22);
            this.txtboxlandname.Name = "txtboxlandname";
            this.txtboxlandname.Size = new System.Drawing.Size(165, 20);
            this.txtboxlandname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbolaender);
            this.groupBox2.Location = new System.Drawing.Point(8, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Länder auswahl:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbolaender
            // 
            this.cbolaender.FormattingEnabled = true;
            this.cbolaender.Location = new System.Drawing.Point(6, 19);
            this.cbolaender.Name = "cbolaender";
            this.cbolaender.Size = new System.Drawing.Size(235, 21);
            this.cbolaender.TabIndex = 0;
            this.cbolaender.SelectedIndexChanged += new System.EventHandler(this.cbolaender_SelectedIndexChanged);
            this.cbolaender.SelectionChangeCommitted += new System.EventHandler(this.cbolaender_SelectionChangeCommitted);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboligaauswahl);
            this.groupBox3.Location = new System.Drawing.Point(8, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liga auswahl:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cboligaauswahl
            // 
            this.cboligaauswahl.FormattingEnabled = true;
            this.cboligaauswahl.Location = new System.Drawing.Point(4, 19);
            this.cboligaauswahl.Name = "cboligaauswahl";
            this.cboligaauswahl.Size = new System.Drawing.Size(235, 21);
            this.cboligaauswahl.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(8, 355);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 300);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Liga Daten:";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(257, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 573);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vereins Daten:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox3);
            this.groupBox6.Location = new System.Drawing.Point(257, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 50);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Vereins auswahl:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(235, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkedListBox1);
            this.groupBox7.Location = new System.Drawing.Point(508, 28);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(245, 628);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Spieler auswahl:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 18);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(238, 619);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.Location = new System.Drawing.Point(1161, 629);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 26);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Tag = "";
            this.btn_Exit.Text = "Beenden";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Location = new System.Drawing.Point(1161, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 26);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpen.Location = new System.Drawing.Point(1161, 542);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(97, 26);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Öffnen";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(758, 27);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(397, 628);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Spieler Daten:";
            // 
            // txtboxenglish
            // 
            this.txtboxenglish.Location = new System.Drawing.Point(73, 48);
            this.txtboxenglish.Name = "txtboxenglish";
            this.txtboxenglish.Size = new System.Drawing.Size(165, 20);
            this.txtboxenglish.TabIndex = 4;
            // 
            // lblname2
            // 
            this.lblname2.AutoSize = true;
            this.lblname2.Location = new System.Drawing.Point(7, 55);
            this.lblname2.Name = "lblname2";
            this.lblname2.Size = new System.Drawing.Size(44, 13);
            this.lblname2.TabIndex = 5;
            this.lblname2.Text = "English:";
            // 
            // lblhauptstadt
            // 
            this.lblhauptstadt.AutoSize = true;
            this.lblhauptstadt.Location = new System.Drawing.Point(7, 106);
            this.lblhauptstadt.Name = "lblhauptstadt";
            this.lblhauptstadt.Size = new System.Drawing.Size(62, 13);
            this.lblhauptstadt.TabIndex = 6;
            this.lblhauptstadt.Text = "Hauptstadt:";
            // 
            // txtboxhauptstadt
            // 
            this.txtboxhauptstadt.Location = new System.Drawing.Point(73, 99);
            this.txtboxhauptstadt.Name = "txtboxhauptstadt";
            this.txtboxhauptstadt.Size = new System.Drawing.Size(165, 20);
            this.txtboxhauptstadt.TabIndex = 7;
            // 
            // txtboxfahne
            // 
            this.txtboxfahne.Location = new System.Drawing.Point(108, 125);
            this.txtboxfahne.Name = "txtboxfahne";
            this.txtboxfahne.Size = new System.Drawing.Size(130, 20);
            this.txtboxfahne.TabIndex = 8;
            // 
            // txtboxfifapunkte
            // 
            this.txtboxfifapunkte.Location = new System.Drawing.Point(73, 151);
            this.txtboxfifapunkte.Name = "txtboxfifapunkte";
            this.txtboxfifapunkte.Size = new System.Drawing.Size(165, 20);
            this.txtboxfifapunkte.TabIndex = 9;
            // 
            // txtboxtransfermarktid
            // 
            this.txtboxtransfermarktid.Location = new System.Drawing.Point(73, 177);
            this.txtboxtransfermarktid.Name = "txtboxtransfermarktid";
            this.txtboxtransfermarktid.Size = new System.Drawing.Size(165, 20);
            this.txtboxtransfermarktid.TabIndex = 10;
            // 
            // lblfahne
            // 
            this.lblfahne.AutoSize = true;
            this.lblfahne.Location = new System.Drawing.Point(7, 132);
            this.lblfahne.Name = "lblfahne";
            this.lblfahne.Size = new System.Drawing.Size(40, 13);
            this.lblfahne.TabIndex = 11;
            this.lblfahne.Text = "Fahne:";
            // 
            // lblfifapunkte
            // 
            this.lblfifapunkte.AutoSize = true;
            this.lblfifapunkte.Location = new System.Drawing.Point(7, 158);
            this.lblfifapunkte.Name = "lblfifapunkte";
            this.lblfifapunkte.Size = new System.Drawing.Size(64, 13);
            this.lblfifapunkte.TabIndex = 12;
            this.lblfifapunkte.Text = "Fifa-Punkte:";
            // 
            // lbltranfermarktid
            // 
            this.lbltranfermarktid.AutoSize = true;
            this.lbltranfermarktid.Location = new System.Drawing.Point(7, 184);
            this.lbltranfermarktid.Name = "lbltranfermarktid";
            this.lbltranfermarktid.Size = new System.Drawing.Size(60, 13);
            this.lbltranfermarktid.TabIndex = 13;
            this.lbltranfermarktid.Text = "Transferm.:";
            // 
            // picboxfahne
            // 
            this.picboxfahne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxfahne.BackgroundImage")));
            this.picboxfahne.InitialImage = ((System.Drawing.Image)(resources.GetObject("picboxfahne.InitialImage")));
            this.picboxfahne.Location = new System.Drawing.Point(73, 126);
            this.picboxfahne.Name = "picboxfahne";
            this.picboxfahne.Size = new System.Drawing.Size(29, 19);
            this.picboxfahne.TabIndex = 14;
            this.picboxfahne.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Datenbank Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxfahne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbolaender;
        private System.Windows.Forms.ComboBox cboligaauswahl;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.TextBox txtboxlandname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxlandeinwohner;
        private System.Windows.Forms.Label lbllandeinwohner;
        private System.Windows.Forms.TextBox txtboxhauptstadt;
        private System.Windows.Forms.Label lblhauptstadt;
        private System.Windows.Forms.Label lblname2;
        private System.Windows.Forms.TextBox txtboxenglish;
        private System.Windows.Forms.Label lbltranfermarktid;
        private System.Windows.Forms.Label lblfifapunkte;
        private System.Windows.Forms.Label lblfahne;
        private System.Windows.Forms.TextBox txtboxtransfermarktid;
        private System.Windows.Forms.TextBox txtboxfifapunkte;
        private System.Windows.Forms.TextBox txtboxfahne;
        private System.Windows.Forms.PictureBox picboxfahne;
    }
}


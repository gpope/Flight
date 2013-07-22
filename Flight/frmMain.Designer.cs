namespace Flight
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katoziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrakoploviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraglajderiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cjenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letniZapisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFlightNETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpMainClanovi = new System.Windows.Forms.FlowLayoutPanel();
            this.bZrakoplov = new System.Windows.Forms.Button();
            this.bParaglajder = new System.Windows.Forms.Button();
            this.bRezervacije = new System.Windows.Forms.Button();
            this.bOsobno = new System.Windows.Forms.Button();
            this.bCijene = new System.Windows.Forms.Button();
            this.bNagradeO = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIme = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPrezime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bClanarine = new System.Windows.Forms.Button();
            this.bLetovi = new System.Windows.Forms.Button();
            this.bRezervacijeLetova = new System.Windows.Forms.Button();
            this.bParaglajderi = new System.Windows.Forms.Button();
            this.bZrakoplovi = new System.Windows.Forms.Button();
            this.bKorisnici = new System.Windows.Forms.Button();
            this.flpAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.bCjenik = new System.Windows.Forms.Button();
            this.bNagrade = new System.Windows.Forms.Button();
            this.msMain.SuspendLayout();
            this.flpMainClanovi.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flpAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.katoziToolStripMenuItem,
            this.letoviToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.MdiWindowListItem = this.fileToolStripMenuItem;
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(895, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zatvoriToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fileToolStripMenuItem.Text = "Aplikacija";
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // katoziToolStripMenuItem
            // 
            this.katoziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.zrakoploviToolStripMenuItem,
            this.paraglajderiToolStripMenuItem,
            this.cjenikToolStripMenuItem});
            this.katoziToolStripMenuItem.Name = "katoziToolStripMenuItem";
            this.katoziToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.katoziToolStripMenuItem.Text = "Katalozi";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // zrakoploviToolStripMenuItem
            // 
            this.zrakoploviToolStripMenuItem.Name = "zrakoploviToolStripMenuItem";
            this.zrakoploviToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.zrakoploviToolStripMenuItem.Text = "Zrakoplovi";
            this.zrakoploviToolStripMenuItem.Click += new System.EventHandler(this.zrakoploviToolStripMenuItem_Click);
            // 
            // paraglajderiToolStripMenuItem
            // 
            this.paraglajderiToolStripMenuItem.Name = "paraglajderiToolStripMenuItem";
            this.paraglajderiToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.paraglajderiToolStripMenuItem.Text = "Paraglajderi";
            this.paraglajderiToolStripMenuItem.Click += new System.EventHandler(this.paraglajderiToolStripMenuItem_Click);
            // 
            // cjenikToolStripMenuItem
            // 
            this.cjenikToolStripMenuItem.Name = "cjenikToolStripMenuItem";
            this.cjenikToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cjenikToolStripMenuItem.Text = "Cjenik";
            this.cjenikToolStripMenuItem.Click += new System.EventHandler(this.cjenikToolStripMenuItem_Click);
            // 
            // letoviToolStripMenuItem
            // 
            this.letoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervacijeToolStripMenuItem,
            this.letniZapisiToolStripMenuItem});
            this.letoviToolStripMenuItem.Name = "letoviToolStripMenuItem";
            this.letoviToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.letoviToolStripMenuItem.Text = "Letovi";
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            this.rezervacijeToolStripMenuItem.Click += new System.EventHandler(this.rezervacijeToolStripMenuItem_Click);
            // 
            // letniZapisiToolStripMenuItem
            // 
            this.letniZapisiToolStripMenuItem.Name = "letniZapisiToolStripMenuItem";
            this.letniZapisiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.letniZapisiToolStripMenuItem.Text = "Letni zapisi";
            this.letniZapisiToolStripMenuItem.Click += new System.EventHandler(this.letniZapisiToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oFlightNETToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oFlightNETToolStripMenuItem
            // 
            this.oFlightNETToolStripMenuItem.Name = "oFlightNETToolStripMenuItem";
            this.oFlightNETToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oFlightNETToolStripMenuItem.Text = "O Flight.NET";
            this.oFlightNETToolStripMenuItem.Click += new System.EventHandler(this.oFlightNETToolStripMenuItem_Click);
            // 
            // flpMainClanovi
            // 
            this.flpMainClanovi.BackColor = System.Drawing.Color.Transparent;
            this.flpMainClanovi.Controls.Add(this.bZrakoplov);
            this.flpMainClanovi.Controls.Add(this.bParaglajder);
            this.flpMainClanovi.Controls.Add(this.bRezervacije);
            this.flpMainClanovi.Controls.Add(this.bOsobno);
            this.flpMainClanovi.Controls.Add(this.bCijene);
            this.flpMainClanovi.Controls.Add(this.bNagradeO);
            this.flpMainClanovi.Location = new System.Drawing.Point(110, 153);
            this.flpMainClanovi.Name = "flpMainClanovi";
            this.flpMainClanovi.Size = new System.Drawing.Size(682, 189);
            this.flpMainClanovi.TabIndex = 1;
            // 
            // bZrakoplov
            // 
            this.bZrakoplov.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bZrakoplov.Location = new System.Drawing.Point(3, 3);
            this.bZrakoplov.Name = "bZrakoplov";
            this.bZrakoplov.Size = new System.Drawing.Size(104, 182);
            this.bZrakoplov.TabIndex = 0;
            this.bZrakoplov.Text = "Zrakoplovi";
            this.bZrakoplov.UseVisualStyleBackColor = false;
            this.bZrakoplov.Click += new System.EventHandler(this.bZrakoplov_Click);
            // 
            // bParaglajder
            // 
            this.bParaglajder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bParaglajder.Location = new System.Drawing.Point(113, 3);
            this.bParaglajder.Name = "bParaglajder";
            this.bParaglajder.Size = new System.Drawing.Size(104, 182);
            this.bParaglajder.TabIndex = 5;
            this.bParaglajder.Text = "Paraglajderi";
            this.bParaglajder.UseVisualStyleBackColor = false;
            this.bParaglajder.Click += new System.EventHandler(this.bParaglajder_Click);
            // 
            // bRezervacije
            // 
            this.bRezervacije.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bRezervacije.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bRezervacije.Location = new System.Drawing.Point(223, 3);
            this.bRezervacije.Name = "bRezervacije";
            this.bRezervacije.Size = new System.Drawing.Size(106, 182);
            this.bRezervacije.TabIndex = 1;
            this.bRezervacije.Text = "Rezervacija letjelica";
            this.bRezervacije.UseVisualStyleBackColor = false;
            this.bRezervacije.Click += new System.EventHandler(this.bRezervacije_Click);
            // 
            // bOsobno
            // 
            this.bOsobno.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bOsobno.Location = new System.Drawing.Point(335, 3);
            this.bOsobno.Name = "bOsobno";
            this.bOsobno.Size = new System.Drawing.Size(109, 182);
            this.bOsobno.TabIndex = 2;
            this.bOsobno.Text = "Osobni podaci";
            this.bOsobno.UseVisualStyleBackColor = false;
            this.bOsobno.Click += new System.EventHandler(this.bOsobno_Click);
            // 
            // bCijene
            // 
            this.bCijene.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bCijene.Location = new System.Drawing.Point(450, 3);
            this.bCijene.Name = "bCijene";
            this.bCijene.Size = new System.Drawing.Size(109, 182);
            this.bCijene.TabIndex = 3;
            this.bCijene.Text = "Cijene";
            this.bCijene.UseVisualStyleBackColor = false;
            this.bCijene.Click += new System.EventHandler(this.bCijene_Click);
            // 
            // bNagradeO
            // 
            this.bNagradeO.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bNagradeO.Location = new System.Drawing.Point(565, 3);
            this.bNagradeO.Name = "bNagradeO";
            this.bNagradeO.Size = new System.Drawing.Size(109, 182);
            this.bNagradeO.TabIndex = 4;
            this.bNagradeO.Text = "Aktivnosti";
            this.bNagradeO.UseVisualStyleBackColor = false;
            this.bNagradeO.Click += new System.EventHandler(this.bNagradeO_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "Korisnik:";
            // 
            // tsslIme
            // 
            this.tsslIme.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.tsslIme.Name = "tsslIme";
            this.tsslIme.Size = new System.Drawing.Size(22, 17);
            this.tsslIme.Text = "Ime";
            // 
            // tsslPrezime
            // 
            this.tsslPrezime.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.tsslPrezime.Name = "tsslPrezime";
            this.tsslPrezime.Size = new System.Drawing.Size(40, 17);
            this.tsslPrezime.Text = "Prezime";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel2.Text = "Status:";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(31, 17);
            this.tsslStatus.Text = "Status";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslIme,
            this.tsslPrezime,
            this.toolStripStatusLabel2,
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(895, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "ss";
            // 
            // bClanarine
            // 
            this.bClanarine.Location = new System.Drawing.Point(408, 3);
            this.bClanarine.Name = "bClanarine";
            this.bClanarine.Size = new System.Drawing.Size(75, 79);
            this.bClanarine.TabIndex = 5;
            this.bClanarine.Text = "Članarine";
            this.bClanarine.UseVisualStyleBackColor = true;
            this.bClanarine.Click += new System.EventHandler(this.bClanarine_Click);
            // 
            // bLetovi
            // 
            this.bLetovi.Location = new System.Drawing.Point(327, 3);
            this.bLetovi.Name = "bLetovi";
            this.bLetovi.Size = new System.Drawing.Size(75, 79);
            this.bLetovi.TabIndex = 4;
            this.bLetovi.Text = "Letovi";
            this.bLetovi.UseVisualStyleBackColor = true;
            this.bLetovi.Click += new System.EventHandler(this.bLetovi_Click);
            // 
            // bRezervacijeLetova
            // 
            this.bRezervacijeLetova.Location = new System.Drawing.Point(246, 3);
            this.bRezervacijeLetova.Name = "bRezervacijeLetova";
            this.bRezervacijeLetova.Size = new System.Drawing.Size(75, 79);
            this.bRezervacijeLetova.TabIndex = 3;
            this.bRezervacijeLetova.Text = "Rezervacije";
            this.bRezervacijeLetova.UseVisualStyleBackColor = true;
            this.bRezervacijeLetova.Click += new System.EventHandler(this.bRezervacijeLetova_Click);
            // 
            // bParaglajderi
            // 
            this.bParaglajderi.Location = new System.Drawing.Point(165, 3);
            this.bParaglajderi.Name = "bParaglajderi";
            this.bParaglajderi.Size = new System.Drawing.Size(75, 79);
            this.bParaglajderi.TabIndex = 2;
            this.bParaglajderi.Text = "Paraglajderi";
            this.bParaglajderi.UseVisualStyleBackColor = true;
            this.bParaglajderi.Click += new System.EventHandler(this.bParaglajderi_Click);
            // 
            // bZrakoplovi
            // 
            this.bZrakoplovi.Location = new System.Drawing.Point(84, 3);
            this.bZrakoplovi.Name = "bZrakoplovi";
            this.bZrakoplovi.Size = new System.Drawing.Size(75, 79);
            this.bZrakoplovi.TabIndex = 1;
            this.bZrakoplovi.Text = "Zrakoplovi";
            this.bZrakoplovi.UseVisualStyleBackColor = true;
            this.bZrakoplovi.Click += new System.EventHandler(this.bZrakoplovi_Click);
            // 
            // bKorisnici
            // 
            this.bKorisnici.Location = new System.Drawing.Point(3, 3);
            this.bKorisnici.Name = "bKorisnici";
            this.bKorisnici.Size = new System.Drawing.Size(75, 79);
            this.bKorisnici.TabIndex = 0;
            this.bKorisnici.Text = "Korisnici";
            this.bKorisnici.UseVisualStyleBackColor = true;
            this.bKorisnici.Click += new System.EventHandler(this.bKorisnici_Click);
            // 
            // flpAdmin
            // 
            this.flpAdmin.BackColor = System.Drawing.Color.Transparent;
            this.flpAdmin.Controls.Add(this.bKorisnici);
            this.flpAdmin.Controls.Add(this.bZrakoplovi);
            this.flpAdmin.Controls.Add(this.bParaglajderi);
            this.flpAdmin.Controls.Add(this.bRezervacijeLetova);
            this.flpAdmin.Controls.Add(this.bLetovi);
            this.flpAdmin.Controls.Add(this.bClanarine);
            this.flpAdmin.Controls.Add(this.bCjenik);
            this.flpAdmin.Controls.Add(this.bNagrade);
            this.flpAdmin.Location = new System.Drawing.Point(125, 348);
            this.flpAdmin.Name = "flpAdmin";
            this.flpAdmin.Size = new System.Drawing.Size(649, 85);
            this.flpAdmin.TabIndex = 3;
            // 
            // bCjenik
            // 
            this.bCjenik.Location = new System.Drawing.Point(489, 3);
            this.bCjenik.Name = "bCjenik";
            this.bCjenik.Size = new System.Drawing.Size(75, 79);
            this.bCjenik.TabIndex = 6;
            this.bCjenik.Text = "Cjenik";
            this.bCjenik.UseVisualStyleBackColor = true;
            this.bCjenik.Click += new System.EventHandler(this.bCjenik_Click);
            // 
            // bNagrade
            // 
            this.bNagrade.Location = new System.Drawing.Point(570, 3);
            this.bNagrade.Name = "bNagrade";
            this.bNagrade.Size = new System.Drawing.Size(75, 79);
            this.bNagrade.TabIndex = 7;
            this.bNagrade.Text = "Aktivnosti";
            this.bNagrade.UseVisualStyleBackColor = true;
            this.bNagrade.Click += new System.EventHandler(this.bNagrade_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(895, 509);
            this.Controls.Add(this.flpAdmin);
            this.Controls.Add(this.flpMainClanovi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight.NET";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.flpMainClanovi.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flpAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katoziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpMainClanovi;
        private System.Windows.Forms.Button bZrakoplov;
        private System.Windows.Forms.Button bRezervacije;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrakoploviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraglajderiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letniZapisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslIme;
        private System.Windows.Forms.ToolStripStatusLabel tsslPrezime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button bOsobno;
        private System.Windows.Forms.FlowLayoutPanel flpAdmin;
        private System.Windows.Forms.Button bKorisnici;
        private System.Windows.Forms.Button bZrakoplovi;
        private System.Windows.Forms.Button bParaglajderi;
        private System.Windows.Forms.Button bRezervacijeLetova;
        private System.Windows.Forms.Button bLetovi;
        private System.Windows.Forms.Button bClanarine;
        private System.Windows.Forms.Button bCjenik;
        private System.Windows.Forms.Button bNagrade;
        private System.Windows.Forms.Button bCijene;
        private System.Windows.Forms.Button bNagradeO;
        private System.Windows.Forms.Button bParaglajder;
        private System.Windows.Forms.ToolStripMenuItem cjenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFlightNETToolStripMenuItem;
    }
}
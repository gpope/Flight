namespace Flight.CatalogForms
{
    partial class frmZatvoriLetniZapis
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
            this.bSpremi = new System.Windows.Forms.Button();
            this.lRezervacijaID = new System.Windows.Forms.Label();
            this.tbRezervacijaID = new System.Windows.Forms.TextBox();
            this.lLetID = new System.Windows.Forms.Label();
            this.tbLetID = new System.Windows.Forms.TextBox();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.tbPlanLeta = new System.Windows.Forms.TextBox();
            this.tbVremenskaPrognoza = new System.Windows.Forms.TextBox();
            this.lNapomena = new System.Windows.Forms.Label();
            this.lGorivoUtroseno = new System.Windows.Forms.Label();
            this.lTrajanjeLeta = new System.Windows.Forms.Label();
            this.lPlanLeta = new System.Windows.Forms.Label();
            this.lVremenskaPrognoza = new System.Windows.Forms.Label();
            this.lKorisnik = new System.Windows.Forms.Label();
            this.lResurs = new System.Windows.Forms.Label();
            this.tbKorisnik = new System.Windows.Forms.TextBox();
            this.tbLetjelica = new System.Windows.Forms.TextBox();
            this.dtpTrajanjeLeta = new System.Windows.Forms.DateTimePicker();
            this.nupGorivoUtoseno = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupGorivoUtoseno)).BeginInit();
            this.SuspendLayout();
            // 
            // bSpremi
            // 
            this.bSpremi.Location = new System.Drawing.Point(347, 302);
            this.bSpremi.Name = "bSpremi";
            this.bSpremi.Size = new System.Drawing.Size(75, 23);
            this.bSpremi.TabIndex = 37;
            this.bSpremi.Text = "Spremi";
            this.bSpremi.UseVisualStyleBackColor = true;
            this.bSpremi.Click += new System.EventHandler(this.bSpremi_Click);
            // 
            // lRezervacijaID
            // 
            this.lRezervacijaID.AutoSize = true;
            this.lRezervacijaID.Location = new System.Drawing.Point(33, 37);
            this.lRezervacijaID.Name = "lRezervacijaID";
            this.lRezervacijaID.Size = new System.Drawing.Size(80, 13);
            this.lRezervacijaID.TabIndex = 34;
            this.lRezervacijaID.Text = "Rezervacija ID:";
            // 
            // tbRezervacijaID
            // 
            this.tbRezervacijaID.Location = new System.Drawing.Point(134, 34);
            this.tbRezervacijaID.Name = "tbRezervacijaID";
            this.tbRezervacijaID.ReadOnly = true;
            this.tbRezervacijaID.Size = new System.Drawing.Size(132, 20);
            this.tbRezervacijaID.TabIndex = 31;
            // 
            // lLetID
            // 
            this.lLetID.AutoSize = true;
            this.lLetID.Location = new System.Drawing.Point(59, 14);
            this.lLetID.Name = "lLetID";
            this.lLetID.Size = new System.Drawing.Size(39, 13);
            this.lLetID.TabIndex = 30;
            this.lLetID.Text = "Let ID:";
            // 
            // tbLetID
            // 
            this.tbLetID.Location = new System.Drawing.Point(134, 8);
            this.tbLetID.Name = "tbLetID";
            this.tbLetID.ReadOnly = true;
            this.tbLetID.Size = new System.Drawing.Size(100, 20);
            this.tbLetID.TabIndex = 29;
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(134, 259);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(293, 37);
            this.tbNapomena.TabIndex = 28;
            // 
            // tbPlanLeta
            // 
            this.tbPlanLeta.Location = new System.Drawing.Point(134, 161);
            this.tbPlanLeta.Multiline = true;
            this.tbPlanLeta.Name = "tbPlanLeta";
            this.tbPlanLeta.ReadOnly = true;
            this.tbPlanLeta.Size = new System.Drawing.Size(293, 40);
            this.tbPlanLeta.TabIndex = 25;
            // 
            // tbVremenskaPrognoza
            // 
            this.tbVremenskaPrognoza.Location = new System.Drawing.Point(134, 115);
            this.tbVremenskaPrognoza.Multiline = true;
            this.tbVremenskaPrognoza.Name = "tbVremenskaPrognoza";
            this.tbVremenskaPrognoza.ReadOnly = true;
            this.tbVremenskaPrognoza.Size = new System.Drawing.Size(293, 39);
            this.tbVremenskaPrognoza.TabIndex = 24;
            // 
            // lNapomena
            // 
            this.lNapomena.AutoSize = true;
            this.lNapomena.Location = new System.Drawing.Point(51, 271);
            this.lNapomena.Name = "lNapomena";
            this.lNapomena.Size = new System.Drawing.Size(62, 13);
            this.lNapomena.TabIndex = 23;
            this.lNapomena.Text = "Napomena:";
            // 
            // lGorivoUtroseno
            // 
            this.lGorivoUtroseno.AutoSize = true;
            this.lGorivoUtroseno.Location = new System.Drawing.Point(28, 235);
            this.lGorivoUtroseno.Name = "lGorivoUtroseno";
            this.lGorivoUtroseno.Size = new System.Drawing.Size(85, 13);
            this.lGorivoUtroseno.TabIndex = 22;
            this.lGorivoUtroseno.Text = "Gorivo utrošeno:";
            // 
            // lTrajanjeLeta
            // 
            this.lTrajanjeLeta.AutoSize = true;
            this.lTrajanjeLeta.Location = new System.Drawing.Point(45, 213);
            this.lTrajanjeLeta.Name = "lTrajanjeLeta";
            this.lTrajanjeLeta.Size = new System.Drawing.Size(68, 13);
            this.lTrajanjeLeta.TabIndex = 21;
            this.lTrajanjeLeta.Text = "Trajanje leta:";
            // 
            // lPlanLeta
            // 
            this.lPlanLeta.AutoSize = true;
            this.lPlanLeta.Location = new System.Drawing.Point(62, 176);
            this.lPlanLeta.Name = "lPlanLeta";
            this.lPlanLeta.Size = new System.Drawing.Size(51, 13);
            this.lPlanLeta.TabIndex = 20;
            this.lPlanLeta.Text = "Plan leta:";
            // 
            // lVremenskaPrognoza
            // 
            this.lVremenskaPrognoza.AutoSize = true;
            this.lVremenskaPrognoza.Location = new System.Drawing.Point(3, 127);
            this.lVremenskaPrognoza.Name = "lVremenskaPrognoza";
            this.lVremenskaPrognoza.Size = new System.Drawing.Size(110, 13);
            this.lVremenskaPrognoza.TabIndex = 19;
            this.lVremenskaPrognoza.Text = "Vremenska prognoza:";
            // 
            // lKorisnik
            // 
            this.lKorisnik.AutoSize = true;
            this.lKorisnik.Location = new System.Drawing.Point(64, 64);
            this.lKorisnik.Name = "lKorisnik";
            this.lKorisnik.Size = new System.Drawing.Size(47, 13);
            this.lKorisnik.TabIndex = 38;
            this.lKorisnik.Text = "Korisnik:";
            // 
            // lResurs
            // 
            this.lResurs.AutoSize = true;
            this.lResurs.Location = new System.Drawing.Point(64, 91);
            this.lResurs.Name = "lResurs";
            this.lResurs.Size = new System.Drawing.Size(49, 13);
            this.lResurs.TabIndex = 39;
            this.lResurs.Text = "Letjelica:";
            // 
            // tbKorisnik
            // 
            this.tbKorisnik.Location = new System.Drawing.Point(134, 61);
            this.tbKorisnik.Name = "tbKorisnik";
            this.tbKorisnik.ReadOnly = true;
            this.tbKorisnik.Size = new System.Drawing.Size(132, 20);
            this.tbKorisnik.TabIndex = 40;
            // 
            // tbLetjelica
            // 
            this.tbLetjelica.Location = new System.Drawing.Point(134, 88);
            this.tbLetjelica.Name = "tbLetjelica";
            this.tbLetjelica.ReadOnly = true;
            this.tbLetjelica.Size = new System.Drawing.Size(132, 20);
            this.tbLetjelica.TabIndex = 41;
            // 
            // dtpTrajanjeLeta
            // 
            this.dtpTrajanjeLeta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTrajanjeLeta.Location = new System.Drawing.Point(134, 207);
            this.dtpTrajanjeLeta.Name = "dtpTrajanjeLeta";
            this.dtpTrajanjeLeta.ShowUpDown = true;
            this.dtpTrajanjeLeta.Size = new System.Drawing.Size(132, 20);
            this.dtpTrajanjeLeta.TabIndex = 42;
            this.dtpTrajanjeLeta.Value = new System.DateTime(2013, 7, 18, 0, 0, 0, 0);
            // 
            // nupGorivoUtoseno
            // 
            this.nupGorivoUtoseno.Location = new System.Drawing.Point(134, 233);
            this.nupGorivoUtoseno.Name = "nupGorivoUtoseno";
            this.nupGorivoUtoseno.Size = new System.Drawing.Size(132, 20);
            this.nupGorivoUtoseno.TabIndex = 43;
            this.nupGorivoUtoseno.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // frmZatvoriLetniZapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.nupGorivoUtoseno);
            this.Controls.Add(this.dtpTrajanjeLeta);
            this.Controls.Add(this.tbLetjelica);
            this.Controls.Add(this.tbKorisnik);
            this.Controls.Add(this.lResurs);
            this.Controls.Add(this.lKorisnik);
            this.Controls.Add(this.bSpremi);
            this.Controls.Add(this.lRezervacijaID);
            this.Controls.Add(this.tbRezervacijaID);
            this.Controls.Add(this.lLetID);
            this.Controls.Add(this.tbLetID);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.tbPlanLeta);
            this.Controls.Add(this.tbVremenskaPrognoza);
            this.Controls.Add(this.lNapomena);
            this.Controls.Add(this.lGorivoUtroseno);
            this.Controls.Add(this.lTrajanjeLeta);
            this.Controls.Add(this.lPlanLeta);
            this.Controls.Add(this.lVremenskaPrognoza);
            this.Name = "frmZatvoriLetniZapis";
            this.Text = "Zatvori Letni zapis";
            this.Load += new System.EventHandler(this.frmZatvoriLetniZapis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupGorivoUtoseno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSpremi;
        private System.Windows.Forms.Label lRezervacijaID;
        private System.Windows.Forms.TextBox tbRezervacijaID;
        private System.Windows.Forms.Label lLetID;
        private System.Windows.Forms.TextBox tbLetID;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.TextBox tbPlanLeta;
        private System.Windows.Forms.TextBox tbVremenskaPrognoza;
        private System.Windows.Forms.Label lNapomena;
        private System.Windows.Forms.Label lGorivoUtroseno;
        private System.Windows.Forms.Label lTrajanjeLeta;
        private System.Windows.Forms.Label lPlanLeta;
        private System.Windows.Forms.Label lVremenskaPrognoza;
        private System.Windows.Forms.Label lKorisnik;
        private System.Windows.Forms.Label lResurs;
        private System.Windows.Forms.TextBox tbKorisnik;
        private System.Windows.Forms.TextBox tbLetjelica;
        private System.Windows.Forms.DateTimePicker dtpTrajanjeLeta;
        private System.Windows.Forms.NumericUpDown nupGorivoUtoseno;
    }
}
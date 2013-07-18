namespace Flight.CatalogForms
{
    partial class frmNoviZrakoplov
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
            this.lID = new System.Windows.Forms.Label();
            this.lNaziv = new System.Windows.Forms.Label();
            this.lModel = new System.Windows.Forms.Label();
            this.lGodProizvodnje = new System.Windows.Forms.Label();
            this.lMaxVisina = new System.Windows.Forms.Label();
            this.lMaxTeret = new System.Windows.Forms.Label();
            this.lRadniSati = new System.Windows.Forms.Label();
            this.lStatusResursa = new System.Windows.Forms.Label();
            this.lTezina = new System.Windows.Forms.Label();
            this.lDuzina = new System.Windows.Forms.Label();
            this.lPromjerKrila = new System.Windows.Forms.Label();
            this.lGorivoSpremnik = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMaxVisina = new System.Windows.Forms.TextBox();
            this.tbMaxTeret = new System.Windows.Forms.TextBox();
            this.tbRadniSati = new System.Windows.Forms.TextBox();
            this.tbTezina = new System.Windows.Forms.TextBox();
            this.tbDuzina = new System.Windows.Forms.TextBox();
            this.lGorivoStanje = new System.Windows.Forms.Label();
            this.lGorivo = new System.Windows.Forms.Label();
            this.tbPromjerKrila = new System.Windows.Forms.TextBox();
            this.tbGorivoSpremnik = new System.Windows.Forms.TextBox();
            this.tbGorivoStanje = new System.Windows.Forms.TextBox();
            this.cbStatusResursa = new System.Windows.Forms.ComboBox();
            this.cbGorivo = new System.Windows.Forms.ComboBox();
            this.bSpremiNoviZrakoplov = new System.Windows.Forms.Button();
            this.dtpGodinaProizvodnje = new System.Windows.Forms.DateTimePicker();
            this.c = new System.Windows.Forms.Panel();
            this.c.SuspendLayout();
            this.SuspendLayout();
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(136, 19);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(21, 13);
            this.lID.TabIndex = 0;
            this.lID.Text = "ID:";
            // 
            // lNaziv
            // 
            this.lNaziv.AutoSize = true;
            this.lNaziv.Location = new System.Drawing.Point(82, 13);
            this.lNaziv.Name = "lNaziv";
            this.lNaziv.Size = new System.Drawing.Size(37, 13);
            this.lNaziv.TabIndex = 1;
            this.lNaziv.Text = "Naziv:";
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.Location = new System.Drawing.Point(80, 39);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(39, 13);
            this.lModel.TabIndex = 2;
            this.lModel.Text = "Model:";
            // 
            // lGodProizvodnje
            // 
            this.lGodProizvodnje.AutoSize = true;
            this.lGodProizvodnje.Location = new System.Drawing.Point(15, 65);
            this.lGodProizvodnje.Name = "lGodProizvodnje";
            this.lGodProizvodnje.Size = new System.Drawing.Size(101, 13);
            this.lGodProizvodnje.TabIndex = 3;
            this.lGodProizvodnje.Text = "Godina proizvodnje:";
            // 
            // lMaxVisina
            // 
            this.lMaxVisina.AutoSize = true;
            this.lMaxVisina.Location = new System.Drawing.Point(20, 91);
            this.lMaxVisina.Name = "lMaxVisina";
            this.lMaxVisina.Size = new System.Drawing.Size(96, 13);
            this.lMaxVisina.TabIndex = 4;
            this.lMaxVisina.Text = "Maksimalna visina:";
            // 
            // lMaxTeret
            // 
            this.lMaxTeret.AutoSize = true;
            this.lMaxTeret.Location = new System.Drawing.Point(30, 117);
            this.lMaxTeret.Name = "lMaxTeret";
            this.lMaxTeret.Size = new System.Drawing.Size(86, 13);
            this.lMaxTeret.TabIndex = 5;
            this.lMaxTeret.Text = "Maksimalni teret:";
            // 
            // lRadniSati
            // 
            this.lRadniSati.AutoSize = true;
            this.lRadniSati.Location = new System.Drawing.Point(59, 143);
            this.lRadniSati.Name = "lRadniSati";
            this.lRadniSati.Size = new System.Drawing.Size(57, 13);
            this.lRadniSati.TabIndex = 6;
            this.lRadniSati.Text = "Radni sati:";
            // 
            // lStatusResursa
            // 
            this.lStatusResursa.AutoSize = true;
            this.lStatusResursa.Location = new System.Drawing.Point(39, 169);
            this.lStatusResursa.Name = "lStatusResursa";
            this.lStatusResursa.Size = new System.Drawing.Size(77, 13);
            this.lStatusResursa.TabIndex = 7;
            this.lStatusResursa.Text = "Status resursa:";
            // 
            // lTezina
            // 
            this.lTezina.AutoSize = true;
            this.lTezina.Location = new System.Drawing.Point(74, 195);
            this.lTezina.Name = "lTezina";
            this.lTezina.Size = new System.Drawing.Size(42, 13);
            this.lTezina.TabIndex = 8;
            this.lTezina.Text = "Tezina:";
            // 
            // lDuzina
            // 
            this.lDuzina.AutoSize = true;
            this.lDuzina.Location = new System.Drawing.Point(73, 221);
            this.lDuzina.Name = "lDuzina";
            this.lDuzina.Size = new System.Drawing.Size(43, 13);
            this.lDuzina.TabIndex = 9;
            this.lDuzina.Text = "Dužina:";
            // 
            // lPromjerKrila
            // 
            this.lPromjerKrila.AutoSize = true;
            this.lPromjerKrila.Location = new System.Drawing.Point(49, 249);
            this.lPromjerKrila.Name = "lPromjerKrila";
            this.lPromjerKrila.Size = new System.Drawing.Size(67, 13);
            this.lPromjerKrila.TabIndex = 10;
            this.lPromjerKrila.Text = "Promjer krila:";
            // 
            // lGorivoSpremnik
            // 
            this.lGorivoSpremnik.AutoSize = true;
            this.lGorivoSpremnik.Location = new System.Drawing.Point(13, 273);
            this.lGorivoSpremnik.Name = "lGorivoSpremnik";
            this.lGorivoSpremnik.Size = new System.Drawing.Size(103, 13);
            this.lGorivoSpremnik.TabIndex = 11;
            this.lGorivoSpremnik.Text = "Gorivo spremnik [ l ]:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(163, 16);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(94, 20);
            this.tbID.TabIndex = 12;
            this.tbID.TabStop = false;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(122, 10);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(178, 20);
            this.tbNaziv.TabIndex = 13;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(122, 36);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(178, 20);
            this.tbModel.TabIndex = 14;
            // 
            // tbMaxVisina
            // 
            this.tbMaxVisina.Location = new System.Drawing.Point(122, 88);
            this.tbMaxVisina.Name = "tbMaxVisina";
            this.tbMaxVisina.Size = new System.Drawing.Size(178, 20);
            this.tbMaxVisina.TabIndex = 16;
            // 
            // tbMaxTeret
            // 
            this.tbMaxTeret.Location = new System.Drawing.Point(122, 114);
            this.tbMaxTeret.Name = "tbMaxTeret";
            this.tbMaxTeret.Size = new System.Drawing.Size(178, 20);
            this.tbMaxTeret.TabIndex = 17;
            // 
            // tbRadniSati
            // 
            this.tbRadniSati.Location = new System.Drawing.Point(122, 140);
            this.tbRadniSati.Name = "tbRadniSati";
            this.tbRadniSati.Size = new System.Drawing.Size(178, 20);
            this.tbRadniSati.TabIndex = 18;
            // 
            // tbTezina
            // 
            this.tbTezina.Location = new System.Drawing.Point(122, 192);
            this.tbTezina.Name = "tbTezina";
            this.tbTezina.Size = new System.Drawing.Size(178, 20);
            this.tbTezina.TabIndex = 20;
            // 
            // tbDuzina
            // 
            this.tbDuzina.Location = new System.Drawing.Point(122, 218);
            this.tbDuzina.Name = "tbDuzina";
            this.tbDuzina.Size = new System.Drawing.Size(178, 20);
            this.tbDuzina.TabIndex = 21;
            // 
            // lGorivoStanje
            // 
            this.lGorivoStanje.AutoSize = true;
            this.lGorivoStanje.Location = new System.Drawing.Point(27, 296);
            this.lGorivoStanje.Name = "lGorivoStanje";
            this.lGorivoStanje.Size = new System.Drawing.Size(89, 13);
            this.lGorivoStanje.TabIndex = 22;
            this.lGorivoStanje.Text = "Gorivo stanje [ l ]:";
            // 
            // lGorivo
            // 
            this.lGorivo.AutoSize = true;
            this.lGorivo.Location = new System.Drawing.Point(75, 321);
            this.lGorivo.Name = "lGorivo";
            this.lGorivo.Size = new System.Drawing.Size(41, 13);
            this.lGorivo.TabIndex = 23;
            this.lGorivo.Text = "Gorivo:";
            // 
            // tbPromjerKrila
            // 
            this.tbPromjerKrila.Location = new System.Drawing.Point(122, 244);
            this.tbPromjerKrila.Name = "tbPromjerKrila";
            this.tbPromjerKrila.Size = new System.Drawing.Size(178, 20);
            this.tbPromjerKrila.TabIndex = 24;
            // 
            // tbGorivoSpremnik
            // 
            this.tbGorivoSpremnik.Location = new System.Drawing.Point(122, 268);
            this.tbGorivoSpremnik.Name = "tbGorivoSpremnik";
            this.tbGorivoSpremnik.Size = new System.Drawing.Size(178, 20);
            this.tbGorivoSpremnik.TabIndex = 25;
            // 
            // tbGorivoStanje
            // 
            this.tbGorivoStanje.Location = new System.Drawing.Point(122, 294);
            this.tbGorivoStanje.Name = "tbGorivoStanje";
            this.tbGorivoStanje.Size = new System.Drawing.Size(178, 20);
            this.tbGorivoStanje.TabIndex = 26;
            // 
            // cbStatusResursa
            // 
            this.cbStatusResursa.FormattingEnabled = true;
            this.cbStatusResursa.Location = new System.Drawing.Point(122, 167);
            this.cbStatusResursa.Name = "cbStatusResursa";
            this.cbStatusResursa.Size = new System.Drawing.Size(178, 21);
            this.cbStatusResursa.TabIndex = 28;
            // 
            // cbGorivo
            // 
            this.cbGorivo.FormattingEnabled = true;
            this.cbGorivo.Location = new System.Drawing.Point(122, 320);
            this.cbGorivo.Name = "cbGorivo";
            this.cbGorivo.Size = new System.Drawing.Size(178, 21);
            this.cbGorivo.TabIndex = 29;
            // 
            // bSpremiNoviZrakoplov
            // 
            this.bSpremiNoviZrakoplov.Location = new System.Drawing.Point(266, 397);
            this.bSpremiNoviZrakoplov.Name = "bSpremiNoviZrakoplov";
            this.bSpremiNoviZrakoplov.Size = new System.Drawing.Size(75, 23);
            this.bSpremiNoviZrakoplov.TabIndex = 30;
            this.bSpremiNoviZrakoplov.Text = "Spremi";
            this.bSpremiNoviZrakoplov.UseVisualStyleBackColor = true;
            this.bSpremiNoviZrakoplov.Click += new System.EventHandler(this.bSpremiNoviZrakoplov_Click);
            // 
            // dtpGodinaProizvodnje
            // 
            this.dtpGodinaProizvodnje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGodinaProizvodnje.Location = new System.Drawing.Point(122, 62);
            this.dtpGodinaProizvodnje.Name = "dtpGodinaProizvodnje";
            this.dtpGodinaProizvodnje.Size = new System.Drawing.Size(178, 20);
            this.dtpGodinaProizvodnje.TabIndex = 31;
            // 
            // c
            // 
            this.c.Controls.Add(this.lNaziv);
            this.c.Controls.Add(this.dtpGodinaProizvodnje);
            this.c.Controls.Add(this.lModel);
            this.c.Controls.Add(this.lGodProizvodnje);
            this.c.Controls.Add(this.cbGorivo);
            this.c.Controls.Add(this.lMaxVisina);
            this.c.Controls.Add(this.cbStatusResursa);
            this.c.Controls.Add(this.lMaxTeret);
            this.c.Controls.Add(this.tbGorivoStanje);
            this.c.Controls.Add(this.lRadniSati);
            this.c.Controls.Add(this.tbGorivoSpremnik);
            this.c.Controls.Add(this.lStatusResursa);
            this.c.Controls.Add(this.tbPromjerKrila);
            this.c.Controls.Add(this.lTezina);
            this.c.Controls.Add(this.lGorivo);
            this.c.Controls.Add(this.lDuzina);
            this.c.Controls.Add(this.lGorivoStanje);
            this.c.Controls.Add(this.lPromjerKrila);
            this.c.Controls.Add(this.tbDuzina);
            this.c.Controls.Add(this.lGorivoSpremnik);
            this.c.Controls.Add(this.tbTezina);
            this.c.Controls.Add(this.tbNaziv);
            this.c.Controls.Add(this.tbRadniSati);
            this.c.Controls.Add(this.tbModel);
            this.c.Controls.Add(this.tbMaxTeret);
            this.c.Controls.Add(this.tbMaxVisina);
            this.c.Location = new System.Drawing.Point(41, 42);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(318, 349);
            this.c.TabIndex = 32;
            // 
            // frmNoviZrakoplov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 428);
            this.Controls.Add(this.c);
            this.Controls.Add(this.bSpremiNoviZrakoplov);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lID);
            this.Name = "frmNoviZrakoplov";
            this.Text = "Novi Zrakoplov";
            this.Load += new System.EventHandler(this.frmNoviZrakoplov_Load);
            this.c.ResumeLayout(false);
            this.c.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lNaziv;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.Label lGodProizvodnje;
        private System.Windows.Forms.Label lMaxVisina;
        private System.Windows.Forms.Label lMaxTeret;
        private System.Windows.Forms.Label lRadniSati;
        private System.Windows.Forms.Label lStatusResursa;
        private System.Windows.Forms.Label lTezina;
        private System.Windows.Forms.Label lDuzina;
        private System.Windows.Forms.Label lPromjerKrila;
        private System.Windows.Forms.Label lGorivoSpremnik;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMaxVisina;
        private System.Windows.Forms.TextBox tbMaxTeret;
        private System.Windows.Forms.TextBox tbRadniSati;
        private System.Windows.Forms.TextBox tbTezina;
        private System.Windows.Forms.TextBox tbDuzina;
        private System.Windows.Forms.Label lGorivoStanje;
        private System.Windows.Forms.Label lGorivo;
        private System.Windows.Forms.TextBox tbPromjerKrila;
        private System.Windows.Forms.TextBox tbGorivoSpremnik;
        private System.Windows.Forms.TextBox tbGorivoStanje;
        private System.Windows.Forms.ComboBox cbStatusResursa;
        private System.Windows.Forms.ComboBox cbGorivo;
        private System.Windows.Forms.Button bSpremiNoviZrakoplov;
        private System.Windows.Forms.DateTimePicker dtpGodinaProizvodnje;
        private System.Windows.Forms.Panel c;
    }
}
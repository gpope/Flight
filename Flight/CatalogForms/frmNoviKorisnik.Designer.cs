namespace Flight.CatalogForms
{
    partial class frmNoviKorisnik
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
            this.components = new System.ComponentModel.Container();
            this.c = new System.Windows.Forms.Panel();
            this.lLozinka = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.bSpremiNovogKorisnika = new System.Windows.Forms.Button();
            this.cbOvlastiKorisnika = new System.Windows.Forms.ComboBox();
            this.cbStatusKorisnika = new System.Windows.Forms.ComboBox();
            this.lOvlastiKorisnika = new System.Windows.Forms.Label();
            this.lStatusKorisnika = new System.Windows.Forms.Label();
            this.tbOib = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lIme = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lPrezime = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.lAdresa = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lTelefon = new System.Windows.Forms.Label();
            this.lOib = new System.Windows.Forms.Label();
            this.lKorisnik_ID = new System.Windows.Forms.Label();
            this.tbKorisnik_ID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ovlastiKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovlastiKorisnikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // c
            // 
            this.c.Controls.Add(this.lLozinka);
            this.c.Controls.Add(this.tbLozinka);
            this.c.Controls.Add(this.bSpremiNovogKorisnika);
            this.c.Controls.Add(this.cbOvlastiKorisnika);
            this.c.Controls.Add(this.cbStatusKorisnika);
            this.c.Controls.Add(this.lOvlastiKorisnika);
            this.c.Controls.Add(this.lStatusKorisnika);
            this.c.Controls.Add(this.tbOib);
            this.c.Controls.Add(this.tbTelefon);
            this.c.Controls.Add(this.lIme);
            this.c.Controls.Add(this.tbEmail);
            this.c.Controls.Add(this.lPrezime);
            this.c.Controls.Add(this.tbAdresa);
            this.c.Controls.Add(this.lAdresa);
            this.c.Controls.Add(this.tbPrezime);
            this.c.Controls.Add(this.lEmail);
            this.c.Controls.Add(this.tbIme);
            this.c.Controls.Add(this.lTelefon);
            this.c.Controls.Add(this.lOib);
            this.c.Location = new System.Drawing.Point(6, 45);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(303, 282);
            this.c.TabIndex = 8;
            // 
            // lLozinka
            // 
            this.lLozinka.AutoSize = true;
            this.lLozinka.Location = new System.Drawing.Point(59, 181);
            this.lLozinka.Name = "lLozinka";
            this.lLozinka.Size = new System.Drawing.Size(47, 13);
            this.lLozinka.TabIndex = 21;
            this.lLozinka.Text = "Lozinka:";
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(120, 175);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(154, 20);
            this.tbLozinka.TabIndex = 15;
            // 
            // bSpremiNovogKorisnika
            // 
            this.bSpremiNovogKorisnika.Location = new System.Drawing.Point(199, 255);
            this.bSpremiNovogKorisnika.Name = "bSpremiNovogKorisnika";
            this.bSpremiNovogKorisnika.Size = new System.Drawing.Size(75, 23);
            this.bSpremiNovogKorisnika.TabIndex = 18;
            this.bSpremiNovogKorisnika.Text = "Spremi";
            this.bSpremiNovogKorisnika.UseVisualStyleBackColor = true;
            this.bSpremiNovogKorisnika.Click += new System.EventHandler(this.bSpremiNovogKorisnika_Click);
            // 
            // cbOvlastiKorisnika
            // 
            this.cbOvlastiKorisnika.FormattingEnabled = true;
            this.cbOvlastiKorisnika.Location = new System.Drawing.Point(120, 228);
            this.cbOvlastiKorisnika.Name = "cbOvlastiKorisnika";
            this.cbOvlastiKorisnika.Size = new System.Drawing.Size(154, 21);
            this.cbOvlastiKorisnika.TabIndex = 17;
            this.cbOvlastiKorisnika.Text = "-------- Izaberi ovlast --------";
            // 
            // cbStatusKorisnika
            // 
            this.cbStatusKorisnika.FormattingEnabled = true;
            this.cbStatusKorisnika.Location = new System.Drawing.Point(120, 201);
            this.cbStatusKorisnika.Name = "cbStatusKorisnika";
            this.cbStatusKorisnika.Size = new System.Drawing.Size(154, 21);
            this.cbStatusKorisnika.TabIndex = 16;
            this.cbStatusKorisnika.Text = "-------- Izaberi status --------";
            // 
            // lOvlastiKorisnika
            // 
            this.lOvlastiKorisnika.AutoSize = true;
            this.lOvlastiKorisnika.Location = new System.Drawing.Point(19, 231);
            this.lOvlastiKorisnika.Name = "lOvlastiKorisnika";
            this.lOvlastiKorisnika.Size = new System.Drawing.Size(87, 13);
            this.lOvlastiKorisnika.TabIndex = 16;
            this.lOvlastiKorisnika.Text = "Ovlasti korisnika:";
            // 
            // lStatusKorisnika
            // 
            this.lStatusKorisnika.AutoSize = true;
            this.lStatusKorisnika.Location = new System.Drawing.Point(21, 204);
            this.lStatusKorisnika.Name = "lStatusKorisnika";
            this.lStatusKorisnika.Size = new System.Drawing.Size(85, 13);
            this.lStatusKorisnika.TabIndex = 15;
            this.lStatusKorisnika.Text = "Status korisnika:";
            // 
            // tbOib
            // 
            this.tbOib.Location = new System.Drawing.Point(120, 149);
            this.tbOib.Name = "tbOib";
            this.tbOib.Size = new System.Drawing.Size(154, 20);
            this.tbOib.TabIndex = 14;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(120, 123);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(154, 20);
            this.tbTelefon.TabIndex = 13;
            // 
            // lIme
            // 
            this.lIme.AutoSize = true;
            this.lIme.Location = new System.Drawing.Point(79, 6);
            this.lIme.Name = "lIme";
            this.lIme.Size = new System.Drawing.Size(27, 13);
            this.lIme.TabIndex = 1;
            this.lIme.Text = "Ime:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(120, 92);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(154, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // lPrezime
            // 
            this.lPrezime.AutoSize = true;
            this.lPrezime.Location = new System.Drawing.Point(62, 35);
            this.lPrezime.Name = "lPrezime";
            this.lPrezime.Size = new System.Drawing.Size(47, 13);
            this.lPrezime.TabIndex = 2;
            this.lPrezime.Text = "Prezime:";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(120, 62);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(154, 20);
            this.tbAdresa.TabIndex = 11;
            // 
            // lAdresa
            // 
            this.lAdresa.AutoSize = true;
            this.lAdresa.Location = new System.Drawing.Point(63, 65);
            this.lAdresa.Name = "lAdresa";
            this.lAdresa.Size = new System.Drawing.Size(43, 13);
            this.lAdresa.TabIndex = 3;
            this.lAdresa.Text = "Adresa:";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(120, 32);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(154, 20);
            this.tbPrezime.TabIndex = 10;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(68, 95);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(38, 13);
            this.lEmail.TabIndex = 4;
            this.lEmail.Text = "Email: ";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(120, 3);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(154, 20);
            this.tbIme.TabIndex = 9;
            // 
            // lTelefon
            // 
            this.lTelefon.AutoSize = true;
            this.lTelefon.Location = new System.Drawing.Point(57, 126);
            this.lTelefon.Name = "lTelefon";
            this.lTelefon.Size = new System.Drawing.Size(49, 13);
            this.lTelefon.TabIndex = 5;
            this.lTelefon.Text = "Telefon: ";
            // 
            // lOib
            // 
            this.lOib.AutoSize = true;
            this.lOib.Location = new System.Drawing.Point(78, 152);
            this.lOib.Name = "lOib";
            this.lOib.Size = new System.Drawing.Size(28, 13);
            this.lOib.TabIndex = 6;
            this.lOib.Text = "OIB:";
            // 
            // lKorisnik_ID
            // 
            this.lKorisnik_ID.AutoSize = true;
            this.lKorisnik_ID.Location = new System.Drawing.Point(51, 22);
            this.lKorisnik_ID.Name = "lKorisnik_ID";
            this.lKorisnik_ID.Size = new System.Drawing.Size(61, 13);
            this.lKorisnik_ID.TabIndex = 0;
            this.lKorisnik_ID.Text = "Korisnik ID:";
            // 
            // tbKorisnik_ID
            // 
            this.tbKorisnik_ID.Location = new System.Drawing.Point(126, 19);
            this.tbKorisnik_ID.Name = "tbKorisnik_ID";
            this.tbKorisnik_ID.ReadOnly = true;
            this.tbKorisnik_ID.Size = new System.Drawing.Size(78, 20);
            this.tbKorisnik_ID.TabIndex = 8;
            this.tbKorisnik_ID.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.tbKorisnik_ID);
            this.groupBox1.Controls.Add(this.lKorisnik_ID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 337);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnik";
            // 
            // ovlastiKorisnikaBindingSource
            // 
            this.ovlastiKorisnikaBindingSource.DataSource = typeof(Flight.OvlastiKorisnika);
            // 
            // frmNoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNoviKorisnik";
            this.Text = "Novi korisnik";
            this.Load += new System.EventHandler(this.frmNoviKorisnik_Load);
            this.c.ResumeLayout(false);
            this.c.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovlastiKorisnikaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel c;
        private System.Windows.Forms.Button bSpremiNovogKorisnika;
        private System.Windows.Forms.ComboBox cbOvlastiKorisnika;
        private System.Windows.Forms.ComboBox cbStatusKorisnika;
        private System.Windows.Forms.Label lOvlastiKorisnika;
        private System.Windows.Forms.Label lStatusKorisnika;
        private System.Windows.Forms.TextBox tbOib;
        private System.Windows.Forms.Label lKorisnik_ID;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lIme;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lPrezime;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label lAdresa;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lTelefon;
        private System.Windows.Forms.TextBox tbKorisnik_ID;
        private System.Windows.Forms.Label lOib;
        private System.Windows.Forms.Label lLozinka;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.BindingSource ovlastiKorisnikaBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
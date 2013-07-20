namespace Flight.CatalogForms
{
    partial class frmKorisnici
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
            this.dgwKorisnici = new System.Windows.Forms.DataGridView();
            this.bNoviKorisnik = new System.Windows.Forms.Button();
            this.bIzmjeniKorisnika = new System.Windows.Forms.Button();
            this.bObrisiKorisnika = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKorisnici)).BeginInit();
            this.c.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwKorisnici
            // 
            this.dgwKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKorisnici.Location = new System.Drawing.Point(12, 12);
            this.dgwKorisnici.Name = "dgwKorisnici";
            this.dgwKorisnici.Size = new System.Drawing.Size(750, 308);
            this.dgwKorisnici.TabIndex = 8;
            this.dgwKorisnici.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwKorisnici_RowHeaderMouseClick);
            // 
            // bNoviKorisnik
            // 
            this.bNoviKorisnik.Location = new System.Drawing.Point(3, 3);
            this.bNoviKorisnik.Name = "bNoviKorisnik";
            this.bNoviKorisnik.Size = new System.Drawing.Size(75, 23);
            this.bNoviKorisnik.TabIndex = 19;
            this.bNoviKorisnik.Text = "Novi";
            this.bNoviKorisnik.UseVisualStyleBackColor = true;
            this.bNoviKorisnik.Click += new System.EventHandler(this.bNoviKorisnik_Click);
            // 
            // bIzmjeniKorisnika
            // 
            this.bIzmjeniKorisnika.Location = new System.Drawing.Point(84, 3);
            this.bIzmjeniKorisnika.Name = "bIzmjeniKorisnika";
            this.bIzmjeniKorisnika.Size = new System.Drawing.Size(75, 23);
            this.bIzmjeniKorisnika.TabIndex = 20;
            this.bIzmjeniKorisnika.Text = "Izmjeni";
            this.bIzmjeniKorisnika.UseVisualStyleBackColor = true;
            this.bIzmjeniKorisnika.Click += new System.EventHandler(this.bIzmjeniKorisnika_Click);
            // 
            // bObrisiKorisnika
            // 
            this.bObrisiKorisnika.Location = new System.Drawing.Point(165, 3);
            this.bObrisiKorisnika.Name = "bObrisiKorisnika";
            this.bObrisiKorisnika.Size = new System.Drawing.Size(75, 23);
            this.bObrisiKorisnika.TabIndex = 21;
            this.bObrisiKorisnika.Text = "Obriši";
            this.bObrisiKorisnika.UseVisualStyleBackColor = true;
            this.bObrisiKorisnika.Click += new System.EventHandler(this.bObrisiKorisnika_Click);
            // 
            // c
            // 
            this.c.Controls.Add(this.bNoviKorisnik);
            this.c.Controls.Add(this.bObrisiKorisnika);
            this.c.Controls.Add(this.bIzmjeniKorisnika);
            this.c.Location = new System.Drawing.Point(513, 326);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(249, 32);
            this.c.TabIndex = 22;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.c);
            this.Controls.Add(this.dgwKorisnici);
            this.Name = "frmKorisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKorisnici)).EndInit();
            this.c.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNoviKorisnik;
        private System.Windows.Forms.Button bIzmjeniKorisnika;
        private System.Windows.Forms.Button bObrisiKorisnika;
        private System.Windows.Forms.DataGridView dgwKorisnici;
        private System.Windows.Forms.Panel c;
    }
}
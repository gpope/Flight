namespace Flight.CatalogForms
{
    partial class frmLetovi
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
            this.tcLetovi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bKreirajLetniZapis = new System.Windows.Forms.Button();
            this.lDatumRezervacije = new System.Windows.Forms.Label();
            this.dtpDatumRezervacije = new System.Windows.Forms.DateTimePicker();
            this.dgwRezervacije = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bZatvoriLetniZapis = new System.Windows.Forms.Button();
            this.dgwAktivniLetovi = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgwZavrseni = new System.Windows.Forms.DataGridView();
            this.tcLetovi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervacije)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAktivniLetovi)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZavrseni)).BeginInit();
            this.SuspendLayout();
            // 
            // tcLetovi
            // 
            this.tcLetovi.Controls.Add(this.tabPage1);
            this.tcLetovi.Controls.Add(this.tabPage2);
            this.tcLetovi.Controls.Add(this.tabPage3);
            this.tcLetovi.Location = new System.Drawing.Point(13, 13);
            this.tcLetovi.Name = "tcLetovi";
            this.tcLetovi.SelectedIndex = 0;
            this.tcLetovi.Size = new System.Drawing.Size(752, 345);
            this.tcLetovi.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bKreirajLetniZapis);
            this.tabPage1.Controls.Add(this.lDatumRezervacije);
            this.tabPage1.Controls.Add(this.dtpDatumRezervacije);
            this.tabPage1.Controls.Add(this.dgwRezervacije);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rezervacije";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bKreirajLetniZapis
            // 
            this.bKreirajLetniZapis.Location = new System.Drawing.Point(78, 84);
            this.bKreirajLetniZapis.Name = "bKreirajLetniZapis";
            this.bKreirajLetniZapis.Size = new System.Drawing.Size(96, 23);
            this.bKreirajLetniZapis.TabIndex = 3;
            this.bKreirajLetniZapis.Text = "Letni zapis";
            this.bKreirajLetniZapis.UseVisualStyleBackColor = true;
            this.bKreirajLetniZapis.Click += new System.EventHandler(this.bKreirajLetniZapis_Click);
            // 
            // lDatumRezervacije
            // 
            this.lDatumRezervacije.AutoSize = true;
            this.lDatumRezervacije.Location = new System.Drawing.Point(13, 18);
            this.lDatumRezervacije.Name = "lDatumRezervacije";
            this.lDatumRezervacije.Size = new System.Drawing.Size(95, 13);
            this.lDatumRezervacije.TabIndex = 2;
            this.lDatumRezervacije.Text = "Datum rezervacije:";
            // 
            // dtpDatumRezervacije
            // 
            this.dtpDatumRezervacije.Location = new System.Drawing.Point(16, 44);
            this.dtpDatumRezervacije.Name = "dtpDatumRezervacije";
            this.dtpDatumRezervacije.Size = new System.Drawing.Size(158, 20);
            this.dtpDatumRezervacije.TabIndex = 1;
            this.dtpDatumRezervacije.ValueChanged += new System.EventHandler(this.dtpDatumRezervacije_ValueChanged);
            // 
            // dgwRezervacije
            // 
            this.dgwRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRezervacije.Location = new System.Drawing.Point(183, 6);
            this.dgwRezervacije.Name = "dgwRezervacije";
            this.dgwRezervacije.Size = new System.Drawing.Size(555, 275);
            this.dgwRezervacije.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bZatvoriLetniZapis);
            this.tabPage2.Controls.Add(this.dgwAktivniLetovi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aktivni";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bZatvoriLetniZapis
            // 
            this.bZatvoriLetniZapis.Location = new System.Drawing.Point(654, 290);
            this.bZatvoriLetniZapis.Name = "bZatvoriLetniZapis";
            this.bZatvoriLetniZapis.Size = new System.Drawing.Size(75, 23);
            this.bZatvoriLetniZapis.TabIndex = 2;
            this.bZatvoriLetniZapis.Text = "Zatvori let";
            this.bZatvoriLetniZapis.UseVisualStyleBackColor = true;
            this.bZatvoriLetniZapis.Click += new System.EventHandler(this.bZatvoriLetniZapis_Click);
            // 
            // dgwAktivniLetovi
            // 
            this.dgwAktivniLetovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAktivniLetovi.Location = new System.Drawing.Point(6, 6);
            this.dgwAktivniLetovi.Name = "dgwAktivniLetovi";
            this.dgwAktivniLetovi.Size = new System.Drawing.Size(732, 278);
            this.dgwAktivniLetovi.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgwZavrseni);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(744, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Završeni";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgwZavrseni
            // 
            this.dgwZavrseni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZavrseni.Location = new System.Drawing.Point(6, 6);
            this.dgwZavrseni.Name = "dgwZavrseni";
            this.dgwZavrseni.Size = new System.Drawing.Size(732, 307);
            this.dgwZavrseni.TabIndex = 2;
            // 
            // frmLetovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.tcLetovi);
            this.Name = "frmLetovi";
            this.Text = "Letni zapisi";
            this.Load += new System.EventHandler(this.frmLetovi_Load);
            this.tcLetovi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervacije)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAktivniLetovi)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwZavrseni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLetovi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgwRezervacije;
        private System.Windows.Forms.DataGridView dgwAktivniLetovi;
        private System.Windows.Forms.DataGridView dgwZavrseni;
        private System.Windows.Forms.DateTimePicker dtpDatumRezervacije;
        private System.Windows.Forms.Label lDatumRezervacije;
        private System.Windows.Forms.Button bKreirajLetniZapis;
        private System.Windows.Forms.Button bZatvoriLetniZapis;
    }
}
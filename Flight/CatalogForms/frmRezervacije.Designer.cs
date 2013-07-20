namespace Flight.CatalogForms
{
    partial class frmRezervacije
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
            this.dtpDatumRezervacije = new System.Windows.Forms.DateTimePicker();
            this.lDatumRezervacije = new System.Windows.Forms.Label();
            this.lPocetakVrijeme = new System.Windows.Forms.Label();
            this.lKrajVrijeme = new System.Windows.Forms.Label();
            this.lResurs = new System.Windows.Forms.Label();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.lbResursi = new System.Windows.Forms.ListBox();
            this.bRezerviraj = new System.Windows.Forms.Button();
            this.bPonisti = new System.Windows.Forms.Button();
            this.dtpPocetakVrijeme = new System.Windows.Forms.DateTimePicker();
            this.dtpKrajVrijeme = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatumRezervacije
            // 
            this.dtpDatumRezervacije.Location = new System.Drawing.Point(120, 12);
            this.dtpDatumRezervacije.Name = "dtpDatumRezervacije";
            this.dtpDatumRezervacije.Size = new System.Drawing.Size(147, 20);
            this.dtpDatumRezervacije.TabIndex = 1;
            this.dtpDatumRezervacije.ValueChanged += new System.EventHandler(this.dtpDatumRezervacije_ValueChanged);
            // 
            // lDatumRezervacije
            // 
            this.lDatumRezervacije.AutoSize = true;
            this.lDatumRezervacije.Location = new System.Drawing.Point(19, 12);
            this.lDatumRezervacije.Name = "lDatumRezervacije";
            this.lDatumRezervacije.Size = new System.Drawing.Size(95, 13);
            this.lDatumRezervacije.TabIndex = 7;
            this.lDatumRezervacije.Text = "Datum rezervacije:";
            // 
            // lPocetakVrijeme
            // 
            this.lPocetakVrijeme.AutoSize = true;
            this.lPocetakVrijeme.Location = new System.Drawing.Point(22, 248);
            this.lPocetakVrijeme.Name = "lPocetakVrijeme";
            this.lPocetakVrijeme.Size = new System.Drawing.Size(92, 13);
            this.lPocetakVrijeme.TabIndex = 8;
            this.lPocetakVrijeme.Text = "Početak [vrijeme]:";
            // 
            // lKrajVrijeme
            // 
            this.lKrajVrijeme.AutoSize = true;
            this.lKrajVrijeme.Location = new System.Drawing.Point(44, 274);
            this.lKrajVrijeme.Name = "lKrajVrijeme";
            this.lKrajVrijeme.Size = new System.Drawing.Size(70, 13);
            this.lKrajVrijeme.TabIndex = 9;
            this.lKrajVrijeme.Text = "Kraj [vrijeme]:";
            // 
            // lResurs
            // 
            this.lResurs.AutoSize = true;
            this.lResurs.Location = new System.Drawing.Point(71, 112);
            this.lResurs.Name = "lResurs";
            this.lResurs.Size = new System.Drawing.Size(43, 13);
            this.lResurs.TabIndex = 10;
            this.lResurs.Text = "Resurs:";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Location = new System.Drawing.Point(288, 12);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.RowHeadersWidth = 42;
            this.dgvRezervacije.Size = new System.Drawing.Size(477, 346);
            this.dgvRezervacije.TabIndex = 11;
            // 
            // lbResursi
            // 
            this.lbResursi.FormattingEnabled = true;
            this.lbResursi.Location = new System.Drawing.Point(120, 38);
            this.lbResursi.Name = "lbResursi";
            this.lbResursi.Size = new System.Drawing.Size(147, 186);
            this.lbResursi.TabIndex = 2;
            // 
            // bRezerviraj
            // 
            this.bRezerviraj.Location = new System.Drawing.Point(189, 306);
            this.bRezerviraj.Name = "bRezerviraj";
            this.bRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.bRezerviraj.TabIndex = 5;
            this.bRezerviraj.Text = "Rezerviraj";
            this.bRezerviraj.UseVisualStyleBackColor = true;
            this.bRezerviraj.Click += new System.EventHandler(this.bRezerviraj_Click);
            // 
            // bPonisti
            // 
            this.bPonisti.Location = new System.Drawing.Point(108, 306);
            this.bPonisti.Name = "bPonisti";
            this.bPonisti.Size = new System.Drawing.Size(75, 23);
            this.bPonisti.TabIndex = 6;
            this.bPonisti.Text = "Poništi";
            this.bPonisti.UseVisualStyleBackColor = true;
            this.bPonisti.Click += new System.EventHandler(this.bPonisti_Click);
            // 
            // dtpPocetakVrijeme
            // 
            this.dtpPocetakVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPocetakVrijeme.Location = new System.Drawing.Point(120, 242);
            this.dtpPocetakVrijeme.Name = "dtpPocetakVrijeme";
            this.dtpPocetakVrijeme.ShowUpDown = true;
            this.dtpPocetakVrijeme.Size = new System.Drawing.Size(147, 20);
            this.dtpPocetakVrijeme.TabIndex = 12;
            this.dtpPocetakVrijeme.Value = new System.DateTime(2013, 7, 18, 0, 0, 0, 0);
            // 
            // dtpKrajVrijeme
            // 
            this.dtpKrajVrijeme.CustomFormat = "";
            this.dtpKrajVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpKrajVrijeme.Location = new System.Drawing.Point(120, 268);
            this.dtpKrajVrijeme.Name = "dtpKrajVrijeme";
            this.dtpKrajVrijeme.ShowUpDown = true;
            this.dtpKrajVrijeme.Size = new System.Drawing.Size(147, 20);
            this.dtpKrajVrijeme.TabIndex = 13;
            this.dtpKrajVrijeme.Value = new System.DateTime(2013, 7, 18, 0, 0, 0, 0);
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.dtpKrajVrijeme);
            this.Controls.Add(this.dtpPocetakVrijeme);
            this.Controls.Add(this.bPonisti);
            this.Controls.Add(this.bRezerviraj);
            this.Controls.Add(this.lbResursi);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.lResurs);
            this.Controls.Add(this.lKrajVrijeme);
            this.Controls.Add(this.lPocetakVrijeme);
            this.Controls.Add(this.lDatumRezervacije);
            this.Controls.Add(this.dtpDatumRezervacije);
            this.Name = "frmRezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumRezervacije;
        private System.Windows.Forms.Label lDatumRezervacije;
        private System.Windows.Forms.Label lPocetakVrijeme;
        private System.Windows.Forms.Label lKrajVrijeme;
        private System.Windows.Forms.Label lResurs;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.ListBox lbResursi;
        private System.Windows.Forms.Button bRezerviraj;
        private System.Windows.Forms.Button bPonisti;
        private System.Windows.Forms.DateTimePicker dtpPocetakVrijeme;
        private System.Windows.Forms.DateTimePicker dtpKrajVrijeme;
    }
}
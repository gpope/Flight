namespace Flight.CatalogForms
{
    partial class frmZrakoplovi
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
            this.dgwZrakoplovi = new System.Windows.Forms.DataGridView();
            this.bNoviZrakoplov = new System.Windows.Forms.Button();
            this.bIzmjeniZrakoplov = new System.Windows.Forms.Button();
            this.bObrisiZrakoplov = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZrakoplovi)).BeginInit();
            this.c.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwZrakoplovi
            // 
            this.dgwZrakoplovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZrakoplovi.Location = new System.Drawing.Point(12, 12);
            this.dgwZrakoplovi.Name = "dgwZrakoplovi";
            this.dgwZrakoplovi.Size = new System.Drawing.Size(753, 311);
            this.dgwZrakoplovi.TabIndex = 0;
            // 
            // bNoviZrakoplov
            // 
            this.bNoviZrakoplov.Location = new System.Drawing.Point(15, 3);
            this.bNoviZrakoplov.Name = "bNoviZrakoplov";
            this.bNoviZrakoplov.Size = new System.Drawing.Size(75, 23);
            this.bNoviZrakoplov.TabIndex = 1;
            this.bNoviZrakoplov.Text = "Novi";
            this.bNoviZrakoplov.UseVisualStyleBackColor = true;
            this.bNoviZrakoplov.Click += new System.EventHandler(this.bNoviZrakoplov_Click);
            // 
            // bIzmjeniZrakoplov
            // 
            this.bIzmjeniZrakoplov.Location = new System.Drawing.Point(96, 3);
            this.bIzmjeniZrakoplov.Name = "bIzmjeniZrakoplov";
            this.bIzmjeniZrakoplov.Size = new System.Drawing.Size(75, 23);
            this.bIzmjeniZrakoplov.TabIndex = 2;
            this.bIzmjeniZrakoplov.Text = "Izmjeni";
            this.bIzmjeniZrakoplov.UseVisualStyleBackColor = true;
            this.bIzmjeniZrakoplov.Click += new System.EventHandler(this.bIzmjeniZrakoplov_Click);
            // 
            // bObrisiZrakoplov
            // 
            this.bObrisiZrakoplov.Location = new System.Drawing.Point(177, 3);
            this.bObrisiZrakoplov.Name = "bObrisiZrakoplov";
            this.bObrisiZrakoplov.Size = new System.Drawing.Size(75, 23);
            this.bObrisiZrakoplov.TabIndex = 3;
            this.bObrisiZrakoplov.Text = "Obriši";
            this.bObrisiZrakoplov.UseVisualStyleBackColor = true;
            this.bObrisiZrakoplov.Click += new System.EventHandler(this.bObrisiZrakoplov_Click);
            // 
            // c
            // 
            this.c.Controls.Add(this.bNoviZrakoplov);
            this.c.Controls.Add(this.bObrisiZrakoplov);
            this.c.Controls.Add(this.bIzmjeniZrakoplov);
            this.c.Location = new System.Drawing.Point(495, 326);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(270, 32);
            this.c.TabIndex = 4;
            // 
            // frmZrakoplovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.c);
            this.Controls.Add(this.dgwZrakoplovi);
            this.Name = "frmZrakoplovi";
            this.Text = "Zrakoplovi";
            this.Load += new System.EventHandler(this.frmZrakoplovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwZrakoplovi)).EndInit();
            this.c.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwZrakoplovi;
        private System.Windows.Forms.Button bNoviZrakoplov;
        private System.Windows.Forms.Button bIzmjeniZrakoplov;
        private System.Windows.Forms.Button bObrisiZrakoplov;
        private System.Windows.Forms.Panel c;
    }
}
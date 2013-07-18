namespace Flight.CatalogForms
{
    partial class frmParaglajderi
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
            this.dgwParaglajderi = new System.Windows.Forms.DataGridView();
            this.c = new System.Windows.Forms.Panel();
            this.bObrisiParaglajder = new System.Windows.Forms.Button();
            this.bIzmjeniParaglajder = new System.Windows.Forms.Button();
            this.bNoviParaglajder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwParaglajderi)).BeginInit();
            this.c.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwParaglajderi
            // 
            this.dgwParaglajderi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwParaglajderi.Location = new System.Drawing.Point(13, 13);
            this.dgwParaglajderi.Name = "dgwParaglajderi";
            this.dgwParaglajderi.Size = new System.Drawing.Size(775, 363);
            this.dgwParaglajderi.TabIndex = 0;
            // 
            // c
            // 
            this.c.Controls.Add(this.bObrisiParaglajder);
            this.c.Controls.Add(this.bIzmjeniParaglajder);
            this.c.Controls.Add(this.bNoviParaglajder);
            this.c.Location = new System.Drawing.Point(538, 382);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(250, 32);
            this.c.TabIndex = 1;
            // 
            // bObrisiParaglajder
            // 
            this.bObrisiParaglajder.Location = new System.Drawing.Point(167, 3);
            this.bObrisiParaglajder.Name = "bObrisiParaglajder";
            this.bObrisiParaglajder.Size = new System.Drawing.Size(75, 23);
            this.bObrisiParaglajder.TabIndex = 2;
            this.bObrisiParaglajder.Text = "Obriši";
            this.bObrisiParaglajder.UseVisualStyleBackColor = true;
            this.bObrisiParaglajder.Click += new System.EventHandler(this.bObrisiParaglajder_Click);
            // 
            // bIzmjeniParaglajder
            // 
            this.bIzmjeniParaglajder.Location = new System.Drawing.Point(86, 3);
            this.bIzmjeniParaglajder.Name = "bIzmjeniParaglajder";
            this.bIzmjeniParaglajder.Size = new System.Drawing.Size(75, 23);
            this.bIzmjeniParaglajder.TabIndex = 1;
            this.bIzmjeniParaglajder.Text = "Izmjeni";
            this.bIzmjeniParaglajder.UseVisualStyleBackColor = true;
            this.bIzmjeniParaglajder.Click += new System.EventHandler(this.bIzmjeniParaglajder_Click);
            // 
            // bNoviParaglajder
            // 
            this.bNoviParaglajder.Location = new System.Drawing.Point(5, 3);
            this.bNoviParaglajder.Name = "bNoviParaglajder";
            this.bNoviParaglajder.Size = new System.Drawing.Size(75, 23);
            this.bNoviParaglajder.TabIndex = 0;
            this.bNoviParaglajder.Text = "Novi";
            this.bNoviParaglajder.UseVisualStyleBackColor = true;
            this.bNoviParaglajder.Click += new System.EventHandler(this.bNoviParaglajder_Click);
            // 
            // frmParaglajderi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.c);
            this.Controls.Add(this.dgwParaglajderi);
            this.Name = "frmParaglajderi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paraglajderi";
            this.Load += new System.EventHandler(this.frmParaglajderi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwParaglajderi)).EndInit();
            this.c.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwParaglajderi;
        private System.Windows.Forms.Panel c;
        private System.Windows.Forms.Button bObrisiParaglajder;
        private System.Windows.Forms.Button bIzmjeniParaglajder;
        private System.Windows.Forms.Button bNoviParaglajder;
    }
}
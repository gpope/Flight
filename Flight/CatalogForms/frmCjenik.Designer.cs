namespace Flight.CatalogForms
{
    partial class frmCjenik
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.dtpVrijediOd = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijediDo = new System.Windows.Forms.DateTimePicker();
            this.lID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCjena = new System.Windows.Forms.TextBox();
            this.lbResurs = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCjenik = new System.Windows.Forms.DataGridView();
            this.c = new System.Windows.Forms.Panel();
            this.c1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCjenik)).BeginInit();
            this.c.SuspendLayout();
            this.c1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSpremi
            // 
            this.bSpremi.Location = new System.Drawing.Point(155, 95);
            this.bSpremi.Name = "bSpremi";
            this.bSpremi.Size = new System.Drawing.Size(75, 23);
            this.bSpremi.TabIndex = 0;
            this.bSpremi.Text = "Spremi";
            this.bSpremi.UseVisualStyleBackColor = true;
            this.bSpremi.Click += new System.EventHandler(this.bSpremi_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(56, 8);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(62, 20);
            this.tbID.TabIndex = 1;
            // 
            // dtpVrijediOd
            // 
            this.dtpVrijediOd.Location = new System.Drawing.Point(70, 17);
            this.dtpVrijediOd.Name = "dtpVrijediOd";
            this.dtpVrijediOd.Size = new System.Drawing.Size(160, 20);
            this.dtpVrijediOd.TabIndex = 2;
            // 
            // dtpVrijediDo
            // 
            this.dtpVrijediDo.Location = new System.Drawing.Point(70, 43);
            this.dtpVrijediDo.Name = "dtpVrijediDo";
            this.dtpVrijediDo.Size = new System.Drawing.Size(160, 20);
            this.dtpVrijediDo.TabIndex = 3;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(19, 11);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(21, 13);
            this.lID.TabIndex = 4;
            this.lID.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resurs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vrijedi od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vrijedi do:";
            // 
            // tbCjena
            // 
            this.tbCjena.Location = new System.Drawing.Point(70, 69);
            this.tbCjena.Name = "tbCjena";
            this.tbCjena.Size = new System.Drawing.Size(160, 20);
            this.tbCjena.TabIndex = 8;
            // 
            // lbResurs
            // 
            this.lbResurs.FormattingEnabled = true;
            this.lbResurs.Location = new System.Drawing.Point(71, 52);
            this.lbResurs.Name = "lbResurs";
            this.lbResurs.Size = new System.Drawing.Size(160, 160);
            this.lbResurs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cjena:";
            // 
            // dgvCjenik
            // 
            this.dgvCjenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCjenik.Location = new System.Drawing.Point(246, 53);
            this.dgvCjenik.Name = "dgvCjenik";
            this.dgvCjenik.Size = new System.Drawing.Size(519, 299);
            this.dgvCjenik.TabIndex = 11;
            // 
            // c
            // 
            this.c.Controls.Add(this.bSpremi);
            this.c.Controls.Add(this.label3);
            this.c.Controls.Add(this.label5);
            this.c.Controls.Add(this.dtpVrijediOd);
            this.c.Controls.Add(this.dtpVrijediDo);
            this.c.Controls.Add(this.tbCjena);
            this.c.Controls.Add(this.label4);
            this.c.Location = new System.Drawing.Point(1, 219);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(239, 133);
            this.c.TabIndex = 12;
            // 
            // c1
            // 
            this.c1.Controls.Add(this.tbID);
            this.c1.Controls.Add(this.lID);
            this.c1.Location = new System.Drawing.Point(15, 12);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(130, 34);
            this.c1.TabIndex = 13;
            // 
            // frmCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.dgvCjenik);
            this.Controls.Add(this.lbResurs);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(793, 408);
            this.Name = "frmCjenik";
            this.Text = "Cjenik";
            this.Load += new System.EventHandler(this.frmCjenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCjenik)).EndInit();
            this.c.ResumeLayout(false);
            this.c.PerformLayout();
            this.c1.ResumeLayout(false);
            this.c1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSpremi;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DateTimePicker dtpVrijediOd;
        private System.Windows.Forms.DateTimePicker dtpVrijediDo;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCjena;
        private System.Windows.Forms.ListBox lbResurs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCjenik;
        private System.Windows.Forms.Panel c;
        private System.Windows.Forms.Panel c1;
    }
}
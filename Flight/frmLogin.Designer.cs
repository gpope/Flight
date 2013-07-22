namespace Flight
{
    partial class frmLogin
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
            this.pLogin = new System.Windows.Forms.Panel();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.lKorisnickoIme = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lLozinka = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.Transparent;
            this.pLogin.Controls.Add(this.tbLozinka);
            this.pLogin.Controls.Add(this.bLogin);
            this.pLogin.Controls.Add(this.lKorisnickoIme);
            this.pLogin.Controls.Add(this.tbKorisnickoIme);
            this.pLogin.Controls.Add(this.lLozinka);
            this.pLogin.Location = new System.Drawing.Point(1, 371);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(798, 64);
            this.pLogin.TabIndex = 0;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(394, 23);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.PasswordChar = '*';
            this.tbLozinka.Size = new System.Drawing.Size(206, 20);
            this.tbLozinka.TabIndex = 2;
            this.tbLozinka.Text = "1234";
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(652, 18);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(126, 29);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Prijava";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // lKorisnickoIme
            // 
            this.lKorisnickoIme.AutoSize = true;
            this.lKorisnickoIme.Location = new System.Drawing.Point(24, 26);
            this.lKorisnickoIme.Name = "lKorisnickoIme";
            this.lKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.lKorisnickoIme.TabIndex = 1;
            this.lKorisnickoIme.Text = "Korisničko ime:";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(108, 23);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(206, 20);
            this.tbKorisnickoIme.TabIndex = 1;
            this.tbKorisnickoIme.Text = "gopopovi@foi.hr";
            // 
            // lLozinka
            // 
            this.lLozinka.AutoSize = true;
            this.lLozinka.Location = new System.Drawing.Point(338, 26);
            this.lLozinka.Name = "lLozinka";
            this.lLozinka.Size = new System.Drawing.Size(50, 13);
            this.lLozinka.TabIndex = 2;
            this.lLozinka.Text = "Lozinka: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flight.Properties.Resources.Piper_sport;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 364);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.bLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight.NET";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label lKorisnickoIme;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label lLozinka;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


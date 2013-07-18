using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        flightnetEntities contex = new flightnetEntities();

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbKorisnickoIme.Text))
            {
                tbKorisnickoIme.BackColor = Color.Coral;
                MessageBox.Show("Unesite korisničko ime!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbKorisnickoIme.Focus();
            }
            else {
                tbKorisnickoIme.BackColor = Color.White;
                if (String.IsNullOrEmpty(tbLozinka.Text))
                {
                    tbLozinka.BackColor = Color.Coral;
                    MessageBox.Show("Unesite lozinku!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbLozinka.Focus();
                }
                else
                {
                    tbLozinka.BackColor = Color.White;
                    
                    //Provjera korisničkog imena i lozinke u bazi

                    var qry = (from k in contex.Korisnik
                              where k.email == tbKorisnickoIme.Text && k.lozinka == tbLozinka.Text
                              select k).FirstOrDefault();
                    
                    
                    if (qry != null)
                    {

                        this.Hide();

                        switch (qry.ovlasti_korisnika_ID) 
                        {
                            case 1:
                                GlobalHelper.trenutna = GlobalHelper.TipOvlasti.Član;
                                GlobalHelper.prezime = qry.prezime;
                                GlobalHelper.ime = qry.ime;
                                GlobalHelper.userID = qry.korisnik_ID;
                                break;
                            case 2:
                                GlobalHelper.trenutna = GlobalHelper.TipOvlasti.Kontrolor;
                                GlobalHelper.prezime = qry.prezime;
                                GlobalHelper.ime = qry.ime;
                                GlobalHelper.userID = qry.korisnik_ID;
                                break;
                            case 3:
                                GlobalHelper.trenutna = GlobalHelper.TipOvlasti.Admin;
                                GlobalHelper.prezime = qry.prezime;
                                GlobalHelper.ime = qry.ime;
                                GlobalHelper.userID = qry.korisnik_ID;
                                break;
                        }

                        frmMain m = new frmMain();
                        m.Show();
                        
                    }
                    else {
                        MessageBox.Show("Korisniči podaci pogrešni! Pokušajte ponovo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbKorisnickoIme.Text = "";
                        tbKorisnickoIme.Focus();
                        tbLozinka.Text = "";
                    }

                }
            }

           
           

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

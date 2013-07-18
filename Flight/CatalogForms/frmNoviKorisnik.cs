using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.CatalogForms
{
    public partial class frmNoviKorisnik : Form
    {
        private int idk;

        public frmNoviKorisnik(int id)
        {
            InitializeComponent();
            idk = id;
        }

        flightnetEntities contex = new flightnetEntities();

        //Spremanje novog korisnika u db
        private void spremiNovogKorisnika() {
            
            Korisnik k = new Korisnik();


                k.ime = tbIme.Text.Trim();
                k.prezime = tbPrezime.Text.Trim();
                k.lozinka = tbLozinka.Text.Trim();
                k.adresa = tbAdresa.Text.Trim();
                k.email = tbEmail.Text.Trim();
                k.telefon = tbTelefon.Text.Trim();
                //k.oib = int.Parse(tbOib.Text);
                k.oib = tbOib.Text.Trim();
                k.status_korisnika_ID = (cbStatusKorisnika.SelectedValue as StatusKorisnika).status_korisnika_ID;
                k.ovlasti_korisnika_ID = (cbOvlastiKorisnika.SelectedValue as OvlastiKorisnika).ovlasti_korisnika_ID;

                contex.Korisnik.Add(k);
                contex.SaveChanges();
                //GlobalHelper.clearControls(c);
                this.Close();                  
        
        }

        private void napuniSelektiranog() {
            Korisnik ki = (from kr in contex.Korisnik
                          where kr.korisnik_ID == idk
                          select kr).FirstOrDefault();


            tbKorisnik_ID.Text = ki.korisnik_ID.ToString();
            tbIme.Text = ki.ime;
            tbPrezime.Text = ki.prezime;
            tbOib.Text = ki.oib;
            tbEmail.Text = ki.email;
            tbAdresa.Text = ki.adresa;
            tbLozinka.Text = ki.lozinka;
            tbTelefon.Text = ki.telefon;
            //Treba još napuniti comboboxeve??????????
            
        }

        //Ažuriranje korisnika
        private void azurirajKorisnika() {
            Korisnik ki = (from kr in contex.Korisnik
                           where kr.korisnik_ID == idk
                           select kr).FirstOrDefault();
            ki.ime = tbIme.Text.Trim();
            ki.prezime = tbPrezime.Text.Trim();
            ki.lozinka = tbLozinka.Text.Trim();
            ki.adresa = tbAdresa.Text.Trim();
            ki.email = tbEmail.Text.Trim();
            ki.telefon = tbTelefon.Text.Trim();
            //k.oib = int.Parse(tbOib.Text);
            ki.oib = tbOib.Text.Trim();
            ki.status_korisnika_ID = (cbStatusKorisnika.SelectedValue as StatusKorisnika).status_korisnika_ID;
            ki.ovlasti_korisnika_ID = (cbOvlastiKorisnika.SelectedValue as OvlastiKorisnika).ovlasti_korisnika_ID;
            
            contex.SaveChanges();
            //GlobalHelper.clearControls(c);
            this.Close(); 
        }

        private void bSpremiNovogKorisnika_Click(object sender, EventArgs e)
        {
            foreach (TextBox t in c.Controls.OfType<TextBox>().OrderBy(x => x.TabIndex))
            {
                
                if (String.IsNullOrEmpty(t.Text))
                {
                    t.BackColor = Color.LightCoral;
                    MessageBox.Show("Niste upisali traženu vrijednost", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    t.Focus();
                    return;
                }
                else
                {
                    t.BackColor = Color.White;
                }
            
            }
            if (idk == 0)
                spremiNovogKorisnika();
            else
                azurirajKorisnika();
        }

        private void frmNoviKorisnik_Load(object sender, EventArgs e)
        {
            napuniComboBox();
            if(idk !=0)
                napuniSelektiranog();
        }
        
        //Napuni combo boxes iz db
        private void napuniComboBox() { 

            var statusi = (from s in contex.StatusKorisnika select s).ToList();
            var ovlasti = (from o in contex.OvlastiKorisnika select o).ToList();

            cbOvlastiKorisnika.DataSource = ovlasti;
            cbOvlastiKorisnika.DisplayMember = "ovlasti_korisnika";

            cbStatusKorisnika.DataSource = statusi;
            cbStatusKorisnika.DisplayMember = "status_korisnika";

            

        }
    }
}

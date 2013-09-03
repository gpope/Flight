using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        /// <summary>
        /// Snima novog korisnika u bazu podataka
        /// </summary>
        private void spremiNovogKorisnika() {
            
            Korisnik k = new Korisnik();


                k.ime = tbIme.Text.Trim();
                k.prezime = tbPrezime.Text.Trim();
                k.lozinka = tbLozinka.Text.Trim();
                k.adresa = tbAdresa.Text.Trim();
                k.email = tbEmail.Text.Trim();
                k.telefon = tbTelefon.Text.Trim();
                k.oib = tbOib.Text.Trim();
                k.status_korisnika_ID = (cbStatusKorisnika.SelectedValue as StatusKorisnika).status_korisnika_ID;
                k.ovlasti_korisnika_ID = (cbOvlastiKorisnika.SelectedValue as OvlastiKorisnika).ovlasti_korisnika_ID;

                contex.Korisnik.Add(k);
                contex.SaveChanges();

                //Slanje emaila novom korisniku
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("admin@aero.hr");
                mail.To.Add(new MailAddress(tbEmail.Text));
                mail.Subject = "Aero klub - registracija";
                mail.Body = "Poštovani " + tbIme.Text + " " + tbPrezime.Text + ",\ndobro došli u Aero klub FOI.\n\nVaše korisničko ime: " + tbEmail.Text + "\nVaša lozinka: " + tbLozinka.Text + "\n\nUgodan let!\nAero klub FOI";

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("aeroklubfoi@gmail.com", "programsko2013"),
                    EnableSsl = true
                };
                client.Send(mail);

                this.Close();                  
        
        }

        /// <summary>
        /// Popunjava formu s podacima o selektiranom korisniku
        /// </summary>
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

        /// <summary>
        /// Ažurira postojećeg korisnika
        /// </summary>
        private void azurirajKorisnika() {
            Korisnik ki = (from kr in contex.Korisnik
                           where kr.korisnik_ID == idk
                           select kr).FirstOrDefault();
            //Ako promjeni lozinku šalje se email o promjeni
            string staralozinka = ki.lozinka;

            ki.ime = tbIme.Text.Trim();
            ki.prezime = tbPrezime.Text.Trim();
            ki.lozinka = tbLozinka.Text.Trim();
            ki.adresa = tbAdresa.Text.Trim();
            ki.email = tbEmail.Text.Trim();
            ki.telefon = tbTelefon.Text.Trim();
            ki.oib = tbOib.Text.Trim();
            ki.status_korisnika_ID = (cbStatusKorisnika.SelectedValue as StatusKorisnika).status_korisnika_ID;
            ki.ovlasti_korisnika_ID = (cbOvlastiKorisnika.SelectedValue as OvlastiKorisnika).ovlasti_korisnika_ID;

            contex.SaveChanges();

            //Slanje emaila korisniku o novim pristupnim podacima
            
            if (staralozinka != tbLozinka.Text)
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("admin@aero.hr");
                mail.To.Add(new MailAddress(tbEmail.Text));
                mail.Subject = "Aero klub - promjena lozinke";
                mail.Body = "Poštovani " + tbIme.Text + " " + tbPrezime.Text + ",\nvaša lozinka je promjenjena.\n\nVaše korisničko ime: " + tbEmail.Text + "\nVaša lozinka: " + tbLozinka.Text + "\n\nUgodan let!\nAero klub FOI";

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("aeroklubfoi@gmail.com", "programsko2013"),
                    EnableSsl = true
                };
                client.Send(mail);
            }
            
            this.Close(); 
        }

        /// <summary>
        /// Klikom na Spremi, provjerava da li su su svi textbox-ovi popunjeni, mjenja boju pozadine za
        /// nepopunjeni textbox koji ima najmanji TabIndex, te ovisno o ID-u sprema ili ažurira korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Kada se forma Load-a, popunjavaju se combobox-evi,
        /// te ako je korisnik selektiran popunjava se forma s podacima o selektiranom korisniku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNoviKorisnik_Load(object sender, EventArgs e)
        {
            napuniComboBox();
            if(idk !=0)
                napuniSelektiranog();
        }
        
        /// <summary>
        /// Popunjava combobox-eve, koji nude mogućnost izbora ovlasti i statusa korisnika
        /// </summary>
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

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
    public partial class frmOsobniPodaci : Form
    {
        public frmOsobniPodaci()
        {
            InitializeComponent();
        }
        flightnetEntities contex = new flightnetEntities();

        private void frmOsobniPodaci_Load(object sender, EventArgs e)
        {
            Korisnik op = (from k in contex.Korisnik where k.korisnik_ID == GlobalHelper.userID select k).FirstOrDefault();

            tbKorisnik_ID.Text = op.korisnik_ID.ToString();
            tbIme.Text = op.ime;
            tbPrezime.Text = op.prezime;
            tbTelefon.Text = op.telefon;
            tbStatusKorisnika.Text = op.StatusKorisnika.status_korisnika;
            tbOib.Text = op.oib;
            tbOvlastiKorisnika.Text = op.OvlastiKorisnika.ovlasti_korisnika;
            tbEmail.Text = op.email;
            tbLozinka.Text = op.lozinka;
            tbAdresa.Text = op.adresa;
 

        }
    }
}

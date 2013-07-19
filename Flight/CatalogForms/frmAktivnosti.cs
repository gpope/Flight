using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.CatalogForms
{
    public partial class frmAktivnosti : Form
    {
        public frmAktivnosti()
        {
            InitializeComponent();
        }
        flightnetEntities contex = new flightnetEntities();
        /// <summary>
        /// Učitava popis korisnika i ukupan broj sati letenja za pojedinog korisnika
        /// </summary>
        private void frmAktivnosti_Load(object sender, EventArgs e)
        {
            //Treba zbrojiti vrijednosti trajanja letova
            var ak = (from a in contex.Let
                      select new
                      {
                          KorisnikID = a.korisnik_ID,
                          Ime = a.Korisnik.ime,
                          Prezime = a.Korisnik.prezime,
                          Sati =  a.trajanje_leta
                      }
            ).ToList();
            
            dgvAktivnosti.DataSource = ak;
        }
    }
}

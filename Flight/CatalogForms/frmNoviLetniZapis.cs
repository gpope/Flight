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
    public partial class frmNoviLetniZapis : Form
    {
        private int selectedReservation;

        public frmNoviLetniZapis(int id)
        {
            InitializeComponent();
            selectedReservation = id;
        }
        flightnetEntities contex = new flightnetEntities();

        private void frmNoviLetniZapis_Load(object sender, EventArgs e)
        {
            tbRezervacijaID.Text = selectedReservation.ToString();

            Rezervacija r = (from rl in contex.Rezervacija where rl.rezervacija_ID == selectedReservation select rl).FirstOrDefault();

            tbKorisnik.Text = r.Korisnik.prezime;
            tbLetjelica.Text = r.Resurs.naziv;
        }

        private void bSpremi_Click(object sender, EventArgs e)
        {
            Let l = new Let();

            l.vreme_prognoza = tbVremenskaPrognoza.Text;
            l.plan_leta = tbPlanLeta.Text;
            //l.trajanje_leta = TimeSpan.Parse(tbTrajanjeLeta.Text);
            //l.gorivo_utroseno = float.Parse(tbGorivoUtroseno.Text);
            //l.napomena = tbNapomena.Text;

            l.rezervacija_ID = selectedReservation;
            
            //??? korisnik_id treba još provjeriti????????????????????????
            var rez = (from r in contex.Rezervacija where tbKorisnik.Text == r.Korisnik.prezime && r.rezervacija_ID == selectedReservation select r).FirstOrDefault();

            int korID = rez.Korisnik.korisnik_ID;
            l.korisnik_ID = korID;
            l.status_leta_ID = 1;


            contex.Let.Add(l);
            contex.SaveChanges();

            this.Close();
        }
    }
}

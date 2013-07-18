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
    public partial class frmZatvoriLetniZapis : Form
    {
        int idk;

        public frmZatvoriLetniZapis(int id)
        {
            InitializeComponent();
            idk = id;
        }
        flightnetEntities contex = new flightnetEntities();

        private void frmZatvoriLetniZapis_Load(object sender, EventArgs e)
        {
            Let l = (from a in contex.Let 
                    // join k in contex.Korisnik on a.korisnik_ID equals k.korisnik_ID
                     //join r in contex.Rezervacija on a.rezervacija_ID equals r.rezervacija_ID
                     where a.let_ID == idk select a).FirstOrDefault();

            tbLetID.Text = idk.ToString();
            tbRezervacijaID.Text = l.rezervacija_ID.ToString();
            tbKorisnik.Text = l.Korisnik.prezime;
            tbLetjelica.Text = l.Rezervacija.Resurs.naziv;
            
            tbVremenskaPrognoza.Text = l.vreme_prognoza;
            tbPlanLeta.Text = l.plan_leta;
            tbNapomena.Text = l.napomena;
            
           
        }

        private void bSpremi_Click(object sender, EventArgs e)
        {
            Let l = (from a in contex.Let where a.let_ID == idk select a).FirstOrDefault();


            //l.trajanje_leta = TimeSpan.Parse(tbTrajanjeLeta.Text);
            l.trajanje_leta = TimeSpan.Parse(dtpTrajanjeLeta.Text);
            //l.gorivo_utroseno = float.Parse(tbGorivoUtroseno.Text);
            l.gorivo_utroseno = float.Parse(nupGorivoUtoseno.Value.ToString());
            l.napomena = tbNapomena.Text;
            l.status_leta_ID = 2;

            contex.SaveChanges();

            this.Close();
        }
    }
}

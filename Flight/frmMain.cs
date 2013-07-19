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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Izbornici na parent formi (frmMain) postaju vidljivi 
        /// kada je korisnik prijavljen u sustav kao administrator
        /// </summary>
        public void upaliAdminIzbornike() {
            flpAdmin.Visible = true;
            msMain.Visible = true;
        }
        /// <summary>
        /// Izbornici na parent formi (frmMain) postaju nevidljivi
        /// kada je korisnik prijavljen kao administrator
        /// </summary>
        public void ugasiAdminIzbornike() {
            flpAdmin.Visible = false;
            msMain.Visible = false;
        }
        /// <summary>
        /// Klikom na Korisnici u glavnom izborniku (msMain) otvara child formu s popisom korisnika
        /// </summary>
        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmKorisnici k = new CatalogForms.frmKorisnici();
            k.MdiParent = this;
            k.Show();
            ugasiAdminIzbornike();
            k.FormClosed += new FormClosedEventHandler(k_FormClosed);
        }
        /// <summary>
        /// Kada se zatvori child forma poziva se metoda kako bi izbornici 
        /// u glavnoj formi (frmMain) postali vidljivi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void k_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            //throw new NotImplementedException();
        }
        
        /// <summary>
        /// Klikom na Rezervacije u glavnom izborniku (msMain) otvara formu s rezervacijama letova
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmRezervacije r = new CatalogForms.frmRezervacije();
            r.MdiParent = this;
            r.Show();
            ugasiAdminIzbornike();
            r.FormClosed += new FormClosedEventHandler(r_FormClosed);

        }
        void r_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            //throw new NotImplementedException();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zrakoploviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmZrakoplovi z = new CatalogForms.frmZrakoplovi();
            z.ShowDialog();
        }

        private void paraglajderiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmParaglajderi p = new CatalogForms.frmParaglajderi();
            p.ShowDialog();

        }

        private void bRezervacije_Click(object sender, EventArgs e)
        {
            CatalogForms.frmRezervacije r = new CatalogForms.frmRezervacije();
            r.MdiParent = this;
            r.Show();
            ugasiAdminIzbornike();
        }

        /// <summary>
        /// Klikom na Letovi/Letni zapisi u glavnom izborniku (msMain) 
        /// otvara child formu s rezervacijama, aktivnim i zavšrenim letovima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void letniZapisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmLetovi l = new CatalogForms.frmLetovi();
            l.MdiParent = this;
            l.Show();
            ugasiAdminIzbornike();
            l.FormClosed += new FormClosedEventHandler(l_FormClosed);
        }

        void l_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            //throw new NotImplementedException();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            flpMainClanovi.BackColor = Color.Transparent;
            flpAdmin.BackColor = Color.Transparent;
          
            
            tsslStatus.Text = GlobalHelper.trenutna.ToString();
            tsslPrezime.Text = GlobalHelper.prezime;
            tsslIme.Text = GlobalHelper.ime;

            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Član)
            {
                msMain.Visible = false;
                flpAdmin.Visible = false;
              
            }
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Kontrolor)
            {
                flpMainClanovi.Visible = false;
            }


            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Admin) {
                flpMainClanovi.Visible = false;
            }

        }


        private void oFlightNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOFlightu o = new frmOFlightu();
            o.ShowDialog();
        }

        private void bParaglajder_Click(object sender, EventArgs e)
        {
            CatalogForms.frmParaglajderi p = new CatalogForms.frmParaglajderi();
            p.ShowDialog();
        }

        private void bZrakoplov_Click(object sender, EventArgs e)
        {
            CatalogForms.frmZrakoplovi z = new CatalogForms.frmZrakoplovi();
            z.ShowDialog();
        }

        private void bNagradeO_Click(object sender, EventArgs e)
        {
            CatalogForms.frmAktivnosti a = new CatalogForms.frmAktivnosti();
            a.ShowDialog();
        }

        /// <summary>
        /// Klikom na gumb Aktivnosti u izborniku otvara formu s popisom korisnika i ukupnom broju sati letenja za
        /// svakog pojedinog korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNagrade_Click(object sender, EventArgs e)
        {
            CatalogForms.frmAktivnosti a = new CatalogForms.frmAktivnosti();
            a.ShowDialog();
        }

        /// <summary>
        /// Klikom na gumb Korisnici u izborniku otvara formu s popisom i podacima o korisnicima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bKorisnici_Click(object sender, EventArgs e)
        {
            CatalogForms.frmKorisnici k = new CatalogForms.frmKorisnici();
            k.ShowDialog();
        }

        /// <summary>
        /// Klikom na gumb Zrakoplovi u izborniku otvara formu s popisom zrakoplova
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bZrakoplovi_Click(object sender, EventArgs e)
        {
            CatalogForms.frmZrakoplovi z = new CatalogForms.frmZrakoplovi();
            z.ShowDialog();
        }
        
        /// <summary>
        /// Klikom na gumb Paraglajderi u izborniku otvara formu s popisom paraglajdera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bParaglajderi_Click(object sender, EventArgs e)
        {
            CatalogForms.frmParaglajderi p = new CatalogForms.frmParaglajderi();
            p.ShowDialog();
        }

        /// <summary>
        /// Klikom na gumb Rezervacije letova u izborniku otvara formu s popisom rezerviranih letova 
        /// i mogućnošću novih rezervacija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRezervacijeLetova_Click(object sender, EventArgs e)
        {
            CatalogForms.frmRezervacije r = new CatalogForms.frmRezervacije();
            r.ShowDialog();
        }

        /// <summary>
        /// Klikom na gumb Letovi u izborniku otvara formu s aktivnim i završenim letovima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLetovi_Click(object sender, EventArgs e)
        {
            CatalogForms.frmLetovi l = new CatalogForms.frmLetovi();
            l.ShowDialog();
        }
        
        /// <summary>
        /// Klikom na gumb Cjenik u izborniku otvara formu s cjenama za resurse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCjenik_Click(object sender, EventArgs e)
        {
            CatalogForms.frmCjenik c = new CatalogForms.frmCjenik();
            c.ShowDialog();
        }

        /// <summary>
        /// Klikom na gumb Članarine u izborniku otvara formu s članarinama 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClanarine_Click(object sender, EventArgs e)
        {
            CatalogForms.frmClanarine cl = new CatalogForms.frmClanarine();
            cl.ShowDialog();
        }

        /// <summary>
        /// Klikom na gumb Osobni podaci  u izborniku otvara formu s podacima o trenutno logiranom korisniku u sustav
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bOsobno_Click(object sender, EventArgs e)
        {
            CatalogForms.frmOsobniPodaci op = new CatalogForms.frmOsobniPodaci();
            op.ShowDialog();
        }

        private void cjenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmCjenik c = new CatalogForms.frmCjenik();
            c.ShowDialog();
        }
        
        /// <summary>
        /// Klikom na gumb Cjene u izborniku otvara formu s cjenama za resurse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCijene_Click(object sender, EventArgs e)
        {
            CatalogForms.frmCjenik c = new CatalogForms.frmCjenik();
            c.ShowDialog();
        }
    }
}

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
        /// Izbornici na formi (frmMain) postaju vidljivi (korisnik = Administrator)
        /// </summary>
        public void upaliAdminIzbornike() {
            //flpAdmin.Visible = true;
            //msMain.Visible = true;
        }
        /// <summary>
        /// Izbornici na formi (frmMain) postaju nevidljivi (korisnik = Administrator)
        /// </summary>
        public void ugasiAdminIzbornike() {
            //flpAdmin.Visible = false;
            //msMain.Visible = false;
        }

        /// <summary>
        /// Glavni izbornik (korisnik = Administrator)
        /// </summary>

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private CatalogForms.frmKorisnici k;
        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (k == null)
            {
                k = new CatalogForms.frmKorisnici();
                k.MdiParent = this;
                k.Show();
                ugasiAdminIzbornike();
                k.FormClosed += new FormClosedEventHandler(k_FormClosed);
            }
            k.Focus();
        }

        void k_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            z = null;
        }

        private CatalogForms.frmZrakoplovi z;
        private void zrakoploviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(z == null ){
            z = new CatalogForms.frmZrakoplovi();
            z.MdiParent = this;
            z.Show();
            ugasiAdminIzbornike();
            z.FormClosed += new FormClosedEventHandler(z_FormClosed);
            }
            z.Focus();
        }

        void z_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            z = null;
        }

        private CatalogForms.frmParaglajderi p;
        private void paraglajderiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (p == null)
            {
                p = new CatalogForms.frmParaglajderi();
                p.MdiParent = this;
                p.Show();
                ugasiAdminIzbornike();
                p.FormClosed += new FormClosedEventHandler(p_FormClosed);
            }
            p.Focus();
        }

        void p_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            p = null;
        }

        private CatalogForms.frmCjenik c;
        private void cjenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (c == null)
            {
                c = new CatalogForms.frmCjenik();
                c.MdiParent = this;
                c.Show();
                ugasiAdminIzbornike();
                c.FormClosed += new FormClosedEventHandler(c_FormClosed);
            }
            c.Focus();
        }

        void c_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            c = null;
        }

        private CatalogForms.frmRezervacije r;
        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( r == null){
                r = new CatalogForms.frmRezervacije();
                r.MdiParent = this;
                r.Show();
                ugasiAdminIzbornike();
                r.FormClosed += new FormClosedEventHandler(r_FormClosed);
            }
            r.Focus();
        }
        void r_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            r = null;
        }

        private CatalogForms.frmLetovi l;
        private void letniZapisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l == null)
            {
                l = new CatalogForms.frmLetovi();
                l.MdiParent = this;
                l.Show();
                ugasiAdminIzbornike();
                l.FormClosed += new FormClosedEventHandler(l_FormClosed);
            }
            l.Focus();
        }

        void l_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            l = null;
        }

        private frmOFlightu o;
        private void oFlightNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(o == null){
                o = new frmOFlightu();
                o.MdiParent = this;
                o.Show();
                ugasiAdminIzbornike();
                o.FormClosed += new FormClosedEventHandler(o_FormClosed);
            }
            o.Focus();
        }
        void o_FormClosed(object sender, FormClosedEventArgs e)
        {
            upaliAdminIzbornike();
            o = null;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                flpAdmin.Visible = false;
                WindowState = FormWindowState.Maximized;
            }

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

        private void bRezervacije_Click(object sender, EventArgs e)
        {
            CatalogForms.frmRezervacije r = new CatalogForms.frmRezervacije();
            r.Show();
        }

        private void bNagradeO_Click(object sender, EventArgs e)
        {
            CatalogForms.frmAktivnosti a = new CatalogForms.frmAktivnosti();
            a.ShowDialog();
        }

        private void bNagrade_Click(object sender, EventArgs e)
        {
            CatalogForms.frmAktivnosti a = new CatalogForms.frmAktivnosti();
            a.ShowDialog();
        }

        private void bKorisnici_Click(object sender, EventArgs e)
        {
            CatalogForms.frmKorisnici k = new CatalogForms.frmKorisnici();
            k.ShowDialog();
        }

        private void bZrakoplovi_Click(object sender, EventArgs e)
        {
            CatalogForms.frmZrakoplovi z = new CatalogForms.frmZrakoplovi();
            z.ShowDialog();
        }
        
        private void bParaglajderi_Click(object sender, EventArgs e)
        {
            CatalogForms.frmParaglajderi p = new CatalogForms.frmParaglajderi();
            p.ShowDialog();
        }

        private void bRezervacijeLetova_Click(object sender, EventArgs e)
        {
            CatalogForms.frmRezervacije r = new CatalogForms.frmRezervacije();
            r.ShowDialog();
        }

        private void bLetovi_Click(object sender, EventArgs e)
        {
            CatalogForms.frmLetovi l = new CatalogForms.frmLetovi();
            l.ShowDialog();
        }
        
        private void bCjenik_Click(object sender, EventArgs e)
        {
            CatalogForms.frmCjenik c = new CatalogForms.frmCjenik();
            c.ShowDialog();
        }

        private void bClanarine_Click(object sender, EventArgs e)
        {
            CatalogForms.frmClanarine cl = new CatalogForms.frmClanarine();
            cl.ShowDialog();
        }

        private void bOsobno_Click(object sender, EventArgs e)
        {
            CatalogForms.frmOsobniPodaci op = new CatalogForms.frmOsobniPodaci();
            op.ShowDialog();
        }
        
        private void bCijene_Click(object sender, EventArgs e)
        {
            CatalogForms.frmCjenik c = new CatalogForms.frmCjenik();
            c.ShowDialog();
        }
    }
}


        
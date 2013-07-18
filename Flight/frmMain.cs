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

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmKorisnici k = new CatalogForms.frmKorisnici();
            k.Show();
        }

        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmRezervacije r = new CatalogForms.frmRezervacije();
            r.Show();
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
            r.ShowDialog();
        }

        private void letniZapisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmLetovi l = new CatalogForms.frmLetovi();
            l.ShowDialog();
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

        private void cjenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForms.frmCjenik c = new CatalogForms.frmCjenik();
            c.ShowDialog();
        }

        private void bCijene_Click(object sender, EventArgs e)
        {
            CatalogForms.frmCjenik c = new CatalogForms.frmCjenik();
            c.ShowDialog();
        }



    }
}

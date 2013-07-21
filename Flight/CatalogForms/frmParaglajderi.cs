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
    public partial class frmParaglajderi : Form
    {
        public frmParaglajderi()
        {
            InitializeComponent();
        }

        flightnetEntities contex = new flightnetEntities();

        /// <summary>
        /// Dobavlja iz baze podatke o paraglajderima i prikazuje ih u dataGridView-u (dgwParaglajderi)
        /// </summary>
        public void refreshGridParaglajderi()
        {

            //Nisam ubacio slika_url...?!?!?
            var paraglajderi = (from z in contex.Paraglajder
                              join r in contex.Resurs on z.resurs_ID equals r.resurs_ID
                              join s in contex.StatusResursa on r.status_resursa_ID equals s.status_resursa_ID
                              select new
                              {
                                  ID = r.resurs_ID,
                                  Naziv = r.naziv,
                                  Model = r.model,
                                  Godina = r.godina_proizvodnje,
                                  Max_visina = r.max_visina,
                                  Max_teret = r.max_teret,
                                  Radni_sati = r.radni_sati,
                                  Status = s.status_resursa,
                                  Krilo_površina = z.povrsina_krila
                              }).ToList();
            dgwParaglajderi.DataSource = paraglajderi;

        }

        private void frmParaglajderi_Load(object sender, EventArgs e)
        {
            refreshGridParaglajderi();
  
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Član)
            {
                c.Visible = false;
            }
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Kontrolor)
            {
                c.Visible = false;
            }

        }

        private CatalogForms.frmNoviParaglajder np;
        /// <summary>
        /// Otvara formu za unos novog paraglajdera
        /// </summary>
        private void bNoviParaglajder_Click(object sender, EventArgs e)
        {
            if (np == null)
            {
                int id = 0;
                np = new frmNoviParaglajder(id);
                np.MdiParent = this.MdiParent;
                np.FormClosed += new FormClosedEventHandler(np_FormClosed);
                np.Show();
            }
            np.Focus();
        }

        void np_FormClosed(object sender, FormClosedEventArgs e)
        {
            np = null;
            refreshGridParaglajderi();
        }

        private CatalogForms.frmNoviParaglajder iz;
        /// <summary>
        /// Otvara formu za izmjenu selektiranog paraglajdera
        /// </summary>
        private void bIzmjeniParaglajder_Click(object sender, EventArgs e)
        {
            if (dgwParaglajderi.SelectedRows.Count == 0)
                MessageBox.Show("Niste selektirali paraglajder!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int id = int.Parse(dgwParaglajderi.SelectedRows[0].Cells[0].Value.ToString());
                if (iz == null)
                {
                    iz = new frmNoviParaglajder(id);
                    iz.MdiParent = this.MdiParent;
                    iz.FormClosed += new FormClosedEventHandler(iz_FormClosed);
                    iz.Show();
                }
                iz.Focus();
            }
        }

        void iz_FormClosed(object sender, FormClosedEventArgs e)
        {
            iz = null;
            refreshGridParaglajderi();
        }

        /// <summary>
        /// Briše selektirani paraglajder iz baze
        /// </summary>
        private void bObrisiParaglajder_Click(object sender, EventArgs e)
        {
            if (dgwParaglajderi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektirali paraglajder!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                int id = int.Parse(dgwParaglajderi.SelectedRows[0].Cells[0].Value.ToString());

                var r = (from z in contex.Paraglajder where z.resurs_ID == id select z);
                var zr = (from z in contex.Resurs where z.resurs_ID == id select z);

                if (r.Count() > 0 && zr.Count() > 0)
                {
                    foreach (Paraglajder z in r)
                    {
                        contex.Paraglajder.Remove(z);
                    }
                    foreach (Resurs z in zr)
                    {
                        contex.Resurs.Remove(z);
                    }
                    contex.SaveChanges();
                    refreshGridParaglajderi();
                }
            }
        }
    }
}

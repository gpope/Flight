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
    public partial class frmZrakoplovi : Form
    {
        public frmZrakoplovi()
        {
            InitializeComponent();
        }

        flightnetEntities contex = new flightnetEntities();

        /// <summary>
        /// Dobavlja podatke o zrakoplovima iz baze i prikazuje ih u dataGridView-u (dgwZrakoplovi)
        /// </summary>
        public void refreshGridZrakoplovi() {
            
            //Nisam ubacio slika_url...?!?!?
            var zrakoplovi = (from z in contex.Zrakoplov
                              join r in contex.Resurs on z.resurs_ID equals r.resurs_ID
                              join s in contex.StatusResursa on r.status_resursa_ID equals s.status_resursa_ID
                              join g in contex.Gorivo on z.gorivo_ID equals g.gorivo_ID
                              select new { ID = r.resurs_ID, Naziv = r.naziv, Model = r.model, 
                                  Godina = r.godina_proizvodnje, Max_visina = r.max_visina, Max_teret = r.max_teret,
                                  Radni_sati = r.radni_sati, Status = s.status_resursa, 
                                  Težina = z.tezina, Dužina = z.duzina, Promjer_krila = z.promjer_krila, 
                                  Gorivo_spremnik = z.gorivo_spremnik, Gorivo_stanje = z.gorivo_stanje, Gorivo = g.gorivo_naziv }).ToList();
            dgwZrakoplovi.DataSource = zrakoplovi;
        
        }

        private void frmZrakoplovi_Load(object sender, EventArgs e)
        {
            refreshGridZrakoplovi();
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Član)
            {
                c.Visible = false;
            }
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Kontrolor)
            {
                c.Visible = false;
            }
            
        }

        private CatalogForms.frmNoviZrakoplov z;
        /// <summary>
        /// Otvara formu za unos novog zrakoplova
        /// </summary>
        private void bNoviZrakoplov_Click(object sender, EventArgs e)
        {
            if (z == null)
            {
                int id = 0;
                z = new frmNoviZrakoplov(id);
                z.MdiParent = this.MdiParent;
                z.FormClosed += new FormClosedEventHandler(z_FormClosed);
                z.Show();
            }
            z.Focus();
        }

        void z_FormClosed(object sender, FormClosedEventArgs e)
        {
            z = null;
            refreshGridZrakoplovi();
        }

        private CatalogForms.frmNoviZrakoplov iz;
        /// <summary>
        /// Otvara formu za izmjenu selektiranog zrakoplova
        /// </summary>
        private void bIzmjeniZrakoplov_Click(object sender, EventArgs e)
        {
            if (dgwZrakoplovi.SelectedRows.Count == 0)
                MessageBox.Show("Niste selektirali zrakoplov", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int id = int.Parse(dgwZrakoplovi.SelectedRows[0].Cells[0].Value.ToString());
                if (iz == null)
                {
                    iz = new frmNoviZrakoplov(id);
                    iz.MdiParent = this.MdiParent;
                    iz.FormClosed += new FormClosedEventHandler(iz_FormClosed);
                    iz.Show();
                    //refreshGridZrakoplovi();
                }
                iz.Focus();
            }
        }

        void iz_FormClosed(object sender, FormClosedEventArgs e)
        {
            iz = null;
            refreshGridZrakoplovi();
        }

        /// <summary>
        /// Briše selektirani zrakoplov iz baze
        /// </summary>
        private void bObrisiZrakoplov_Click(object sender, EventArgs e)
        {
            if (iz != null)
            {
                MessageBox.Show("Ne možete izbrisati zrakoplov ako je selektiran za izmjenu!");
                iz.Focus();
            }
            else
            {
                if (dgwZrakoplovi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Niste selektirali zrakoplov!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    int id = int.Parse(dgwZrakoplovi.SelectedRows[0].Cells[0].Value.ToString());

                    var r = (from z in contex.Zrakoplov where z.resurs_ID == id select z);
                    var zr = (from z in contex.Resurs where z.resurs_ID == id select z);

                    if (r.Count() > 0 && zr.Count() > 0)
                    {
                        foreach (Zrakoplov z in r)
                        {
                            contex.Zrakoplov.Remove(z);
                        }
                        foreach (Resurs z in zr)
                        {
                            contex.Resurs.Remove(z);
                        }
                        contex.SaveChanges();
                        refreshGridZrakoplovi();
                    }
                }
            }
        }

        

    }
}

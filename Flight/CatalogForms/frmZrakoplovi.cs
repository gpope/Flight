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

        private void bNoviZrakoplov_Click(object sender, EventArgs e)
        {
            int id = 0;
            CatalogForms.frmNoviZrakoplov nz = new frmNoviZrakoplov(id);
            nz.ShowDialog();
            refreshGridZrakoplovi();
        }

        private void bIzmjeniZrakoplov_Click(object sender, EventArgs e)
        {
            if (dgwZrakoplovi.SelectedRows.Count == 0)
                MessageBox.Show("Niste selektirali zrakoplov", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int id = int.Parse(dgwZrakoplovi.SelectedRows[0].Cells[0].Value.ToString());

                CatalogForms.frmNoviZrakoplov iz = new CatalogForms.frmNoviZrakoplov(id);
                iz.ShowDialog();
                refreshGridZrakoplovi();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bObrisiZrakoplov_Click(object sender, EventArgs e)
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
                        //contex.SaveChanges();
                    }
                    foreach (Resurs z in zr)
                    {
                        contex.Resurs.Remove(z);
                        //contex.SaveChanges();
                    }
                    contex.SaveChanges();
                    refreshGridZrakoplovi();
                }
            }

        }

        

    }
}

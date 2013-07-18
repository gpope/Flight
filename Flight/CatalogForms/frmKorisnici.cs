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
    public partial class frmKorisnici : Form
    {
        public frmKorisnici()
        {
            InitializeComponent();
        }
        
        flightnetEntities contex = new flightnetEntities();

        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            refreshGrid();
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Član)
            {
                c.Visible = false;
            }
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Kontrolor)
            {
                c.Visible = false;
            }
        }

        public void refreshGrid(){
            var korisnici = (from k in contex.Korisnik 
                             join o in contex.OvlastiKorisnika on k.ovlasti_korisnika_ID equals o.ovlasti_korisnika_ID
                             join s in contex.StatusKorisnika on k.status_korisnika_ID equals s.status_korisnika_ID
                             select new { ID = k.korisnik_ID, Ime = k.ime, Prezime = k.prezime, Email = k.email, Adresa = k.adresa, OIB = k.oib, Telefon = k.telefon, Ovlasti = o.ovlasti_korisnika, Status = s.status_korisnika }).ToList();
            dgwKorisnici.DataSource = korisnici;
    
        }

        private void bNoviKorisnik_Click(object sender, EventArgs e)
        {
            int id = 0;
            CatalogForms.frmNoviKorisnik n = new CatalogForms.frmNoviKorisnik(id);
            n.ShowDialog();
            refreshGrid();
        }

        //Selektiramo korisnika - redak u datagridview-u
        private void dgwKorisnici_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(dgwKorisnici.SelectedRows[0].Cells[0].Value.ToString());
           
        }

        private void bIzmjeniKorisnika_Click(object sender, EventArgs e)
        {
            //ako nije selektiran korisnik za izmjenu
            if (dgwKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektirali korisnika!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //ako je korisnik selektiran
            else
            {
                int id = int.Parse(dgwKorisnici.SelectedRows[0].Cells[0].Value.ToString());
                CatalogForms.frmNoviKorisnik i = new CatalogForms.frmNoviKorisnik(id);
                i.ShowDialog();
                refreshGrid();
            }
        }

        private void bObrisiKorisnika_Click(object sender, EventArgs e)
        {
            //ako nije selektiran korisnik za izmjenu
            if (dgwKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektirali korisnika!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //ako je korisnik selektiran
            else
            {
                //Korisnik bk = new Korisnik();
                int id = int.Parse(dgwKorisnici.SelectedRows[0].Cells[0].Value.ToString());
                var result = (from kzb in contex.Korisnik where kzb.korisnik_ID == id select kzb);

                if (result.Count() > 0) {
                    foreach(Korisnik k in result)
                        contex.Korisnik.Remove(k);
                    contex.SaveChanges();
                }

                refreshGrid();
            }
        }



    }
}

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
    public partial class frmRezervacije : Form
    {
        public frmRezervacije()
        {
            InitializeComponent();
        }
        DateTime selectedDateC;
        flightnetEntities contex = new flightnetEntities();

        private void refreshLBResursi(){

            var resursi = (from r in contex.Resurs select r).ToList();
            lbResursi.DataSource = resursi;
            lbResursi.DisplayMember = "naziv";
        
        }

        //Grid prikazuje rezervacije za izabrani datum

        private void refreshGridRezervacijeDate(DateTime selectedDateC)
        {

            DateTime selectedDate = selectedDateC;

            var rDate = (from r in contex.Rezervacija
                         join k in contex.Korisnik on r.korisnik_ID equals k.korisnik_ID
                         join l in contex.Resurs on r.resurs_ID equals l.resurs_ID
                         where r.datum == selectedDate
                         select new { ID = r.rezervacija_ID, Resurs = l.naziv, Datum = r.datum, Vrijeme_početak = r.sati_od, Vrijeme_kraj = r.sati_do, Rezervirao = k.prezime }).ToList();
            dgvRezervacije.DataSource = rDate;
        
        }

        //Grid prikazuje sve rezervacije
        private void refreshGridRezervacije() {
            var rezervacije = (from r in contex.Rezervacija
                               join k in contex.Korisnik on r.korisnik_ID equals k.korisnik_ID
                               join l in contex.Resurs on r.resurs_ID equals l.resurs_ID
                               select new { ID = r.rezervacija_ID, Resurs = l.naziv, Datum = r.datum, Vrijeme_početak = r.sati_od, Vrijeme_kraj = r.sati_do, Rezervirao = k.prezime }).ToList();
            dgvRezervacije.DataSource = rezervacije;
        
        }

        private void frmRezervacije_Load(object sender, EventArgs e)
        {
            refreshLBResursi();
           // refreshGridRezervacije();
            selectedDateC = DateTime.Parse(dtpDatumRezervacije.Text);
            refreshGridRezervacijeDate(selectedDateC);
        }

        private void bRezerviraj_Click(object sender, EventArgs e)
        {
            Rezervacija r = new Rezervacija();
            

            string naziv = (lbResursi.SelectedItem as Resurs).naziv;
            
            //ID resursa na osnovu naziva resursa iz list box-a
            var res = (from n in contex.Resurs where n.naziv == naziv select n).FirstOrDefault();

            r.resurs_ID = res.resurs_ID;
            r.datum = DateTime.Parse(dtpDatumRezervacije.Text);
           // r.sati_od = TimeSpan.Parse(tbPocetakVrijeme.Text);
            r.sati_od = TimeSpan.Parse(dtpPocetakVrijeme.Text);
           // r.sati_do = TimeSpan.Parse(tbKrajVrijeme.Text);
            r.sati_do = TimeSpan.Parse(dtpKrajVrijeme.Text);
           
            //globalna varijabla korisnik_id
            r.korisnik_ID = GlobalHelper.userID;
            //r.korisnik_ID = 2;

            contex.Rezervacija.Add(r);
            contex.SaveChanges();
            //refreshGridRezervacije();
            DateTime selectedDateC = DateTime.Parse(dtpDatumRezervacije.Text);
            refreshGridRezervacijeDate(selectedDateC);
            /*
            foreach (TextBox t in Controls.OfType<TextBox>().OrderBy( x => x.TabIndex)) {
                t.Text = "";
            }
            */
        }

        private void bPonisti_Click(object sender, EventArgs e)
        {
            if (dgvRezervacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektirali rezervaciju!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                int selectedrow = int.Parse(dgvRezervacije.SelectedRows[0].Cells[0].Value.ToString());

                var selected = (from r in contex.Rezervacija where r.rezervacija_ID == selectedrow select r);
                if (selected.Count() > 0)
                {
                    foreach (Rezervacija r in selected)
                    {
                        contex.Rezervacija.Remove(r);
                    }
                    contex.SaveChanges();
                    //refreshGridRezervacije();
                    DateTime selectedDateC = DateTime.Parse(dtpDatumRezervacije.Text);
                    refreshGridRezervacijeDate(selectedDateC);
                }
            }
        }

        private void dtpDatumRezervacije_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateC = DateTime.Parse(dtpDatumRezervacije.Text);
            refreshGridRezervacijeDate(selectedDateC);
        }

    }
}

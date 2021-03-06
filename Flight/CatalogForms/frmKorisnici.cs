﻿using System;
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

            /// <summary>
            /// Za korisnike s ovlastima Član kluba i kontrolor ne prikazuje panel c koji sadrži
            /// dugmad s dugmadima za kreiranje Novog, izmjenu postojećeg i brisanje postojećeg korisnika
            /// </summary>
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Član)
            {
                c.Visible = false;
            }
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Kontrolor)
            {
                c.Visible = false;
            }
        }

        /// <summary>
        ///Popunjava dataGridView (dgwKorisnici) s podacima o postojećim korisnicima
        /// </summary>
        public void refreshGrid(){
            var korisnici = (from k in contex.Korisnik 
                             join o in contex.OvlastiKorisnika on k.ovlasti_korisnika_ID equals o.ovlasti_korisnika_ID
                             join s in contex.StatusKorisnika on k.status_korisnika_ID equals s.status_korisnika_ID
                             select new { ID = k.korisnik_ID, Ime = k.ime, Prezime = k.prezime, Email = k.email, Adresa = k.adresa, OIB = k.oib, Telefon = k.telefon, Ovlasti = o.ovlasti_korisnika, Status = s.status_korisnika }).ToList();
            dgwKorisnici.DataSource = korisnici;
    
        }

        /// <summary>
        /// Otvara formu s poljima za unos podataka o novom korisniku
        /// </summary>
        private CatalogForms.frmNoviKorisnik n;
        private void bNoviKorisnik_Click(object sender, EventArgs e)
        {
            if (n == null)
            {
                int id = 0;
                n = new frmNoviKorisnik(id);
                n.MdiParent = this.MdiParent;
                n.FormClosed += new FormClosedEventHandler(n_FormClosed);
                n.Show();
            }
            n.Focus();
        }

        void n_FormClosed(object sender, FormClosedEventArgs e)
        {
            n = null;
            refreshGrid();
        }

        private CatalogForms.frmNoviKorisnik i;
        /// <summary>
        /// Otvara formu za izmjenu podataka o selektiranom korisniku
        /// </summary>
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
                if (i == null)
                {
                    i = new frmNoviKorisnik(id);
                    i.MdiParent = this.MdiParent;
                    i.FormClosed += new FormClosedEventHandler(i_FormClosed);
                    i.Show();
                }
                i.Focus();
            }
        }

        void i_FormClosed(object sender, FormClosedEventArgs e)
        {
            i = null;
            refreshGrid();
        }

        /// <summary>
        /// Briše selektiranog korisnika iz baze
        /// </summary> 
        private void bObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if (i != null)
            {
                MessageBox.Show("Ne možete obrisati korisnika ako je selektiran za ažuriranje");
                i.Focus();
            }
            else
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
                    var result = (from kzb in contex.Korisnik where kzb.korisnik_ID == id select kzb);

                    if (result.Count() > 0)
                    {
                        foreach (Korisnik k in result)
                            contex.Korisnik.Remove(k);
                        contex.SaveChanges();
                        refreshGrid();
                    }
                }
            }   
        }

    }
}

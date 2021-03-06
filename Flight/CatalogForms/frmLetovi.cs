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
    public partial class frmLetovi : Form
    {
        public frmLetovi()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Datum iz dateTimePicker-a (dtpDatumRezervacije)
        /// </summary>
        DateTime selectedDateC;

        flightnetEntities contex = new flightnetEntities();

        /// <summary>
        /// Dobavlja podatke o aktivnim letovima iz baze i prikazuje ih u dataGridView-u (dgwAktivniLetovi)
        /// </summary>
        private void refreshGridAktivniLetovi(){

            var aletovi = (from al in contex.Let
                           join k in contex.Korisnik on al.korisnik_ID equals k.korisnik_ID
                           join r in contex.Rezervacija on al.rezervacija_ID equals r.rezervacija_ID
                           join sl in contex.StatusLeta on al.status_leta_ID equals sl.status_leta_ID
                           where al.status_leta_ID == 1
                           select new 
                           {
                               ID = al.let_ID, 
                               Rezervacija_ID = r.rezervacija_ID, 
                               Korisnik = k.prezime, 
                               Plan_leta = al.plan_leta, 
                               Vrijeme = al.vreme_prognoza, 
                               Trajanje_leta = al.trajanje_leta,
                               Gorivo_utrošeno = al.gorivo_utroseno, 
                               Napomena = al.napomena, 
                               Status_leta = sl.status_leta
                           }).ToList();
           
            dgwAktivniLetovi.DataSource = aletovi;
        }

        /// <summary>
        /// Dobavlja podatke o završenim letovima iz baze i prikazuje ih u dataGridView-u (dgwZavršeniLetovi)
        /// </summary>
        private void refreshGridZavrseniLetovi() {

            var zletovi = (from zl in contex.Let   
                           join k in contex.Korisnik on zl.korisnik_ID equals k.korisnik_ID
                           join r in contex.Rezervacija on zl.rezervacija_ID equals r.rezervacija_ID
                           join sl in contex.StatusLeta on zl.status_leta_ID equals sl.status_leta_ID
                           where zl.status_leta_ID == 2
                           select new
                           {
                               ID = zl.let_ID,
                               Rezervacija_ID = r.rezervacija_ID,
                               Korisnik = k.prezime,
                               Plan_leta = zl.plan_leta,
                               Vrijeme = zl.vreme_prognoza,
                               Trajanje_leta = zl.trajanje_leta,
                               Gorivo_utrošeno = zl.gorivo_utroseno,
                               Napomena = zl.napomena,
                               Status_leta = sl.status_leta
                           }).ToList();
           
            dgwZavrseni.DataSource = zletovi;
        }
       
        /// <summary>
        /// Dobavlja rezervacije za selektirani datum iz baze i prikazuje ih u dataGridView-u (dgwRezervacije)
        /// </summary>
        /// <param name="selectedDateC">Selektirani datum</param>
        private void refreshGridRezervacijeDate(DateTime selectedDateC)
        {

            DateTime selectedDate = selectedDateC;

            var rDate = (from r in contex.Rezervacija
                         join k in contex.Korisnik on r.korisnik_ID equals k.korisnik_ID
                         join l in contex.Resurs on r.resurs_ID equals l.resurs_ID
                         where r.datum == selectedDate
                         select new { ID = r.rezervacija_ID, Resurs = l.naziv, Datum = r.datum, Vrijeme_početak = r.sati_od, Vrijeme_kraj = r.sati_do, Rezervirao = k.prezime }).ToList();
            dgwRezervacije.DataSource = rDate;

        }

        private void frmLetovi_Load(object sender, EventArgs e)
        {
            refreshGridAktivniLetovi();
            refreshGridZavrseniLetovi();
            selectedDateC = DateTime.Parse(dtpDatumRezervacije.Text);
            refreshGridRezervacijeDate(selectedDateC);
        }

        private void dtpDatumRezervacije_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateC = DateTime.Parse(dtpDatumRezervacije.Text);
            refreshGridRezervacijeDate(selectedDateC);
        }

        private CatalogForms.frmNoviLetniZapis nlz;
        /// <summary>
        /// Za selektiranu rezervaciju otvara formu "novi letni zapis" koja se popunjava s podacima prije samog leta
        /// </summary>
        private void bKreirajLetniZapis_Click(object sender, EventArgs e)
        {
            if (dgwRezervacije.SelectedRows.Count != 1)
                MessageBox.Show("Niste selektirali rezervaciju!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int id = int.Parse(dgwRezervacije.SelectedRows[0].Cells[0].Value.ToString());
                if (nlz == null)
                {
                    nlz = new frmNoviLetniZapis(id);
                    nlz.MdiParent = this.MdiParent;
                    nlz.FormClosed += new FormClosedEventHandler(nlz_FormClosed);
                    nlz.Show();           
                }
                nlz.Focus();
            }
        }

        void nlz_FormClosed(object sender, FormClosedEventArgs e)
        {
            nlz = null;
            refreshGridAktivniLetovi();
        }

        private CatalogForms.frmZatvoriLetniZapis zlz;
        /// <summary>
        /// Za selektirani aktivni let (letni zapis), otvara formu koja se popunjava s podacima nakon završetka leta
        /// </summary>
        private void bZatvoriLetniZapis_Click(object sender, EventArgs e)
        {
            if (dgwAktivniLetovi.SelectedRows.Count != 1)
            {
                MessageBox.Show("Niste selektirali let!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                int id = int.Parse(dgwAktivniLetovi.SelectedRows[0].Cells[0].Value.ToString());
                if (zlz == null)
                {
                    zlz = new frmZatvoriLetniZapis(id);
                    zlz.MdiParent = this.MdiParent;
                    zlz.FormClosed += new FormClosedEventHandler(zlz_FormClosed);
                    zlz.Show();
                }
                zlz.Focus();
            }
        }

        void zlz_FormClosed(object sender, FormClosedEventArgs e)
        {
            zlz = null;
            refreshGridAktivniLetovi();
            refreshGridZavrseniLetovi();
        }

    }
}

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
    public partial class frmNoviZrakoplov : Form
    {
        private int idk;
        public frmNoviZrakoplov(int id)
        {
            InitializeComponent();
            idk = id;
        }

        flightnetEntities contex = new flightnetEntities();

        private void napuniComboBox() { 

            var goriva = (from g in contex.Gorivo select g).ToList();
            var statusiResursa = (from sr in contex.StatusResursa select sr).ToList();

            cbStatusResursa.DataSource = statusiResursa;
            cbStatusResursa.DisplayMember = "status_resursa";

            cbGorivo.DataSource = goriva;
            cbGorivo.DisplayMember = "gorivo_naziv";
            

        }

        private void bSpremiNoviZrakoplov_Click(object sender, EventArgs e)
        {
            foreach (TextBox t in c.Controls.OfType<TextBox>().OrderBy(x => x.TabIndex))
            {

                if (String.IsNullOrEmpty(t.Text))
                {
                    t.BackColor = Color.LightCoral;
                    MessageBox.Show("Niste upisali traženu vrijednost", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    t.Focus();
                    return;
                }
                else
                {
                    t.BackColor = Color.White;
                }

            }
            if (idk == 0)
            {
                spremiNoviZrakoplov();
            }
            else {
                azurirajZrakoplov();
            }
        }
        private void spremiNoviZrakoplov() {
            Zrakoplov z = new Zrakoplov();
            Resurs r = new Resurs();

            //zrakoplov nasljeđuje resurs ..... problem s primarnim ključem?!?!?!??

            r.naziv = tbNaziv.Text.Trim();
            r.model = tbModel.Text.Trim();
            r.godina_proizvodnje = dtpGodinaProizvodnje.Value;
            r.max_visina = int.Parse(tbMaxVisina.Text);
            r.max_teret = float.Parse(tbMaxTeret.Text);
            r.radni_sati = int.Parse(tbRadniSati.Text);
            r.status_resursa_ID = (cbStatusResursa.SelectedValue as StatusResursa).status_resursa_ID;

            contex.Resurs.Add(r);
            contex.SaveChanges();

            z.resurs_ID = r.resurs_ID;
            z.tezina = float.Parse(tbTezina.Text);
            z.duzina = float.Parse(tbDuzina.Text);
            z.promjer_krila = float.Parse(tbPromjerKrila.Text);
            z.gorivo_spremnik = float.Parse(tbGorivoSpremnik.Text);
            z.gorivo_stanje = float.Parse(tbGorivoStanje.Text);
            z.gorivo_ID = (cbGorivo.SelectedValue as Gorivo).gorivo_ID;
            
            
            
            contex.Zrakoplov.Add(z);
            contex.SaveChanges();

            this.Close();


        }

        private void azurirajZrakoplov() {
            Zrakoplov zs = (from z in contex.Zrakoplov
                            where z.resurs_ID == idk
                            select z).FirstOrDefault();

            Resurs rs = (from r in contex.Resurs
                         where r.resurs_ID == idk
                         select r).FirstOrDefault();

            //zrakoplov nasljeđuje resurs ..... problem s primarnim ključem?!?!?!??
            
            rs.naziv = tbNaziv.Text.Trim();
            rs.model = tbModel.Text.Trim();
            rs.godina_proizvodnje = dtpGodinaProizvodnje.Value;
            rs.max_visina = int.Parse(tbMaxVisina.Text);
            rs.max_teret = float.Parse(tbMaxTeret.Text);
            rs.radni_sati = int.Parse(tbRadniSati.Text);
            rs.status_resursa_ID = (cbStatusResursa.SelectedValue as StatusResursa).status_resursa_ID;

            contex.SaveChanges();

            zs.resurs_ID = rs.resurs_ID;
            zs.tezina = float.Parse(tbTezina.Text);
            zs.duzina = float.Parse(tbDuzina.Text);
            zs.promjer_krila = float.Parse(tbPromjerKrila.Text);
            zs.gorivo_spremnik = float.Parse(tbGorivoSpremnik.Text);
            zs.gorivo_stanje = float.Parse(tbGorivoStanje.Text);
            zs.gorivo_ID = (cbGorivo.SelectedValue as Gorivo).gorivo_ID;


            contex.SaveChanges();

            this.Close();
            
        }

        private void napuniSelektiranog() {

            Zrakoplov zs = (from z in contex.Zrakoplov
                           where z.resurs_ID == idk
                           select z).FirstOrDefault();

            Resurs rs = (from r in contex.Resurs
                            where r.resurs_ID == idk
                            select r).FirstOrDefault();

            tbID.Text = zs.resurs_ID.ToString();
            tbNaziv.Text = rs.naziv;
            tbModel.Text = rs.model;

            //DateTimePicker - treba učitati vrijednost iz db
            //dtpGodinaProizvodnje.Value = zs.godina_proizvodnje;
            
            tbMaxVisina.Text = rs.max_visina.ToString();
            tbMaxTeret.Text = rs.max_teret.ToString();
            tbRadniSati.Text = rs.radni_sati.ToString();
            //treba napuniti comboboxe
            //1.status_resursa_id

            tbTezina.Text = zs.tezina.ToString();
            tbDuzina.Text = zs.duzina.ToString();
            tbPromjerKrila.Text = zs.promjer_krila.ToString();
            tbGorivoSpremnik.Text = zs.gorivo_spremnik.ToString();
            tbGorivoStanje.Text = zs.gorivo_stanje.ToString();

            //2. combo box gorivo_id




        }

        private void frmNoviZrakoplov_Load(object sender, EventArgs e)
        {
            napuniComboBox();

            if (idk != 0)
            {
                napuniSelektiranog();
            }
        }
    }
}

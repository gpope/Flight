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
    public partial class frmNoviParaglajder : Form
    {
        private int idk;
        public frmNoviParaglajder(int id)
        {
            InitializeComponent();
            idk = id;
        }

        flightnetEntities contex = new flightnetEntities();

        private void napuniComboBox()
        {

            var statusiResursa = (from sr in contex.StatusResursa select sr).ToList();

            cbStatusResursa.DataSource = statusiResursa;
            cbStatusResursa.DisplayMember = "status_resursa";

        }

        private void bSpremiNoviParaglajder_Click(object sender, EventArgs e)
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
                spremiNoviParaglajder();
            }
            else
            {
                azurirajParaglajder();
            }
        }

        private void spremiNoviParaglajder()
        {
            Paraglajder z = new Paraglajder();
            Resurs r = new Resurs();

            //paraglajder nasljeđuje resurs ..... problem s primarnim ključem?!?!?!??

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
            z.povrsina_krila = int.Parse(tbPovrsinaKrila.Text);
            
            contex.Paraglajder.Add(z);
            contex.SaveChanges();

            this.Close();
        }

        private void azurirajParaglajder()
        {
            Paraglajder zs = (from z in contex.Paraglajder
                            where z.resurs_ID == idk
                            select z).FirstOrDefault();

            Resurs rs = (from r in contex.Resurs
                         where r.resurs_ID == idk
                         select r).FirstOrDefault();

            //paraglajder nasljeđuje resurs ..... problem s primarnim ključem?!?!?!??

            rs.naziv = tbNaziv.Text.Trim();
            rs.model = tbModel.Text.Trim();
            rs.godina_proizvodnje = dtpGodinaProizvodnje.Value;
            rs.max_visina = int.Parse(tbMaxVisina.Text);
            rs.max_teret = float.Parse(tbMaxTeret.Text);
            rs.radni_sati = int.Parse(tbRadniSati.Text);
            rs.status_resursa_ID = (cbStatusResursa.SelectedValue as StatusResursa).status_resursa_ID;

            contex.SaveChanges();

            zs.resurs_ID = rs.resurs_ID;
            zs.povrsina_krila = int.Parse(tbPovrsinaKrila.Text);
            
            contex.SaveChanges();

            this.Close();

        }

        private void napuniSelektiranog()
        {

            Paraglajder zs = (from z in contex.Paraglajder
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
            //treba napuniti combobox
            //status_resursa_id

            tbPovrsinaKrila.Text = zs.povrsina_krila.ToString();

        }

        private void frmNoviParaglajder_Load(object sender, EventArgs e)
        {
            napuniComboBox();

            if (idk != 0)
            {
                napuniSelektiranog();
            }
        }



    }
}

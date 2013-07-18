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
    public partial class frmCjenik : Form
    {
        public frmCjenik()
        {
            InitializeComponent();
        }
        flightnetEntities contex = new flightnetEntities();

        private void refreshLBResursi()
        {

            var resursi = (from r in contex.Resurs select r).ToList();
            lbResurs.DataSource = resursi;
            lbResurs.DisplayMember = "naziv";

        }

        private void frmCjenik_Load(object sender, EventArgs e)
        {
            refreshLBResursi();
            refreshGridCjenik();
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Član)
            {
                c.Visible = false;
                c1.Visible = false;
            }
            if (GlobalHelper.trenutna == GlobalHelper.TipOvlasti.Kontrolor)
            {
                c.Visible = false;
                c1.Visible = false;
            }
        }

        private void refreshGridCjenik() {

            var cr = (from c in contex.Cjenik select new 
            { 
                id = c.cjenik_ID, 
                Letjelica = c.Resurs.naziv, 
                Cjena = c.cjena,
                Datum_od = c.datum_od,
                Datum_do = c.datum_od
            
            }).ToList();
            dgvCjenik.DataSource = cr;
        }

        private void bSpremi_Click(object sender, EventArgs e)
        {
            Cjenik c = new Cjenik();
            c.resurs_ID = (lbResurs.SelectedItem as Resurs).resurs_ID;
            c.cjena = float.Parse(tbCjena.Text);
            c.datum_od = DateTime.Parse(dtpVrijediOd.Text);
            c.datum_do = DateTime.Parse(dtpVrijediDo.Text);

            contex.Cjenik.Add(c);
            contex.SaveChanges();

            refreshGridCjenik();


        }
    }
}

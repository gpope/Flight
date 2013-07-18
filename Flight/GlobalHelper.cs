using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
*/


namespace Flight
{
    class GlobalHelper
    {
       //Podaci o korisniku logiranom u sustav
        public enum TipOvlasti { Admin = 3, Kontrolor = 2, Član = 1 };
        public static TipOvlasti trenutna { get; set; }
        public static string prezime;
        public static string ime;
        public static int userID;
               
        //Briše podatke iz forme 

        public static void clearControls(Control c) {
            foreach(TextBox t in c.Controls.OfType<TextBox>()){
                t.Text = "";
            }
        }
       
    }
}

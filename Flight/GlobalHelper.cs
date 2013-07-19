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
        /// <summary>
        /// Imamo tri vrste korisnika: administrator, kontrolor leta i član kluba s različitm razinama ovlasti
        /// </summary>
        public enum TipOvlasti { Admin = 3, Kontrolor = 2, Član = 1 };
        public static TipOvlasti trenutna { get; set; }

        /// <summary>
        /// Podaci o korisniku ulogiranom u sustav
        /// </summary>
        public static string prezime;
        public static string ime;
        public static int userID;

        /// <summary>
        /// Briše sadržaj textbox-ova
        /// </summary>
        /// <param name="c">panel unutar kojeg se nalaze textbox-ovima</param>
        public static void clearControls(Control c) {
            foreach(TextBox t in c.Controls.OfType<TextBox>()){
                t.Text = "";
            }
        }
       
    }
}

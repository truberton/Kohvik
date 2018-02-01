using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Kohvik
{
    class Toode
    {
        public string Nimi;
        public bool PiimOlemas;
        public string TegemiseViis;

        public void Ostmine()
        {
            string Tekst = "Teie ostsite " + Nimi + " mida tehakse järgnevalt: " + TegemiseViis + "\n";
            File.AppendAllText("OstetudAsjad.txt", Tekst);
            MessageBox.Show(Tekst);
        }
    }
}

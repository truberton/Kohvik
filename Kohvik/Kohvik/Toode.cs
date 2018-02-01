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
        public string TegemiseViis;

        public void Ostmine()
        {
            string Tekst = "Teie ostsite " + Nimi + " mida tehakse järgnevalt: " + TegemiseViis;
            File.AppendAllText("OstetudAsjad.txt", Tekst + Environment.NewLine);
            MessageBox.Show(Tekst);
        }
        public virtual void PagartooteOstmine(string Kohvi)
        {
            string Tekst = "Teie ostsite " + Nimi + ", head isu!";
            MessageBox.Show(Tekst);
            File.AppendAllText("OstetudAsjad.txt", Tekst + Environment.NewLine);
        }
    }
}

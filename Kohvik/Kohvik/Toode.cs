using System;
using System.IO;
using System.Windows.Forms;

namespace Kohvik
{
    class Toode
    {
        public string Nimi;
        public string TegemiseViis;
        public double Hind;

        public void Ostmine()
        {
            string Tekst = "Teie ostsite " + Nimi + " mida tehakse järgnevalt: " + TegemiseViis;
            File.AppendAllText("OstetudAsjad.txt", "1x " + Nimi + " €" + Hind + Environment.NewLine);
            MessageBox.Show(Tekst);
        }
        public virtual void PagartooteOstmine(string Kohvi)
        {
            string Tekst = "Teie ostsite " + Nimi + ", head isu!";
            File.AppendAllText("OstetudAsjad.txt", "1x " + Nimi + " €" + Hind + Environment.NewLine);
            MessageBox.Show(Tekst);
        }
    }
}

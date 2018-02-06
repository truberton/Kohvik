using System;
using System.Windows.Forms;
using System.IO;

namespace Kohvik
{
    public partial class Kohvik : Form
    {
        protected string KohviTüüp { get; set; }
        protected bool KohviOlemas { get; set; }
        protected double KokkuLäheb { get; set; }

        public Kohvik()
        {
            InitializeComponent();

            Kohvi.Items.Add("Must kohvi");
            Kohvi.Items.Add("Cappuccino");
            Kohvi.Items.Add("Caffe latte");
            Kohvi.Items.Add("Espresso");

            Toit.Items.Add("Mitte midagi");
            Toit.Items.Add("Sõõrik");
            Toit.Items.Add("Saiake");
            Toit.Items.Add("Croissant");
        }

        private void Kohvi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Toit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Osta_Click(object sender, EventArgs e)
        {
            try
            {
                KohviTüüp = Kohvi.SelectedItem.ToString();
            }
            catch (Exception)
            {
                KohviTüüp = "";
                KohviOlemas = false;
            }
            if (Toit.SelectedIndex > 0) //Teeb kindlaks, et Toit comboboxist on valitud mingi toit mitte mitte midagi või "Mitte midagi"
            {
                switch (Toit.SelectedItem.ToString())
                {
                    case "Sõõrik":
                        var Sõõrik = new Sõõrik();
                        Sõõrik.PagartooteOstmine(KohviTüüp);
                        break;
                    case "Saiake":
                        var Saiake = new Saiake();
                        Saiake.PagartooteOstmine(KohviTüüp);
                        break;
                    case "Croissant":
                        var Croissant = new Croissant();
                        Croissant.PagartooteOstmine(KohviTüüp);
                        break;
                    default:
                        MessageBox.Show("Miski on valesti");
                        break;
                }
            }
            else if (Kohvi.SelectedIndex > -1)
            {
                switch (KohviTüüp)
                {
                    case "Must kohvi":
                        var MustKohvi = new MustKohvi();
                        MustKohvi.Ostmine();
                        break;
                    case "Cappuccino":
                        var Cappuccino = new Cappuccino();
                        Cappuccino.Ostmine();
                        break;
                    case "Caffe latte":
                        var CaffeLatte = new CaffeLatte();
                        CaffeLatte.Ostmine();
                        break;
                    case "Espresso":
                        var Espresso = new Espresso();
                        Espresso.Ostmine();
                        break;
                    default:
                        MessageBox.Show("Valige palun midagi");
                        break;
                }
            }
            foreach (string line in File.ReadLines("OstetudAsjad.txt"))
            {
                if (!line.Contains("Kokku") || !line.Contains ("-"))
                {
                    string Kokku = line.Substring(line.LastIndexOf("€"));
                    Kokku = Kokku.Replace("€", "");
                    KokkuLäheb += Convert.ToDouble(Kokku); 
                }
            }
        }

        private void Kohvik_FormClosing(object sender, FormClosingEventArgs e) //Kui panna forms kinni, siis lisab tšekki totali
        {
            File.AppendAllText("OstetudAsjad.txt", "------------------------" + Environment.NewLine +
                "Kokku: " + "€" + KokkuLäheb);
        }
    }
}

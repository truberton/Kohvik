namespace Kohvik
{
    class Sõõrik : Toode
    {
        public Sõõrik()
        {
            Nimi = "Sõõrik";
            Hind = 2;
        }
        public override void PagartooteOstmine(string Kohvi)
        {
            base.PagartooteOstmine(Kohvi);
            if (!string.IsNullOrWhiteSpace(Kohvi))
            {
                switch (Kohvi)
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
                } 
            }
        }
    }
}

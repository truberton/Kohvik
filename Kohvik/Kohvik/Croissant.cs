namespace Kohvik
{
    class Croissant : Toode
    {
        public Croissant()
        {
            Nimi = "Croissant";
            Hind = 1.33;
        }
        public override void PagartooteOstmine(string Kohvi)
        {
            base.PagartooteOstmine(Kohvi);
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

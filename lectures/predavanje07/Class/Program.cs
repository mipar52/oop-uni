
static void Main(string[] args)
{
    Tvrtka Tvrtka = new Tvrtka("Ime");
    Automobil automobil = new Automobil(
        DateTime.Now, 
        "12345", 
        "Audijo", 
        "Brzi", 
        5,
        7, 
        10000, 
        new List<Rezervoar> 
        {
            new AutoRezervoar
            {
                Tip.Struja,
                12
            }
        }
        )
        Automobil automobil = new Automobil(
        DateTime.Now, 
        "12345", 
        "Audijo", 
        "Brzi", 
        5,
        7, 
        10000, 
        new List<Rezervoar> 
        {
            new AutoRezervoar
            {
                Tip.Struja,
                12
            }
        }
        )
        Automobil automobil = new Automobil(
        DateTime.Now, 
        "12345", 
        "Audijo", 
        "Brzi", 
        5,
        7, 
        10000, 
        new List<Rezervoar> 
        {
            new AutoRezervoar
            {
                Tip.Struja,
                12
            }
        }
        )

    Dobavljac dobavljac = new Dobavljac("ime", "prezime", "1234", "fdfdfd", "nemoj zvat", new List<Banka> {"", ""});
    Kupac kupac = new Kupac("ime", "prezime", "1234", "fdfdfd", "nemoj zvat", new List<Banka> {"", ""});
    Nabava nabava = new Nabava(DateTime.Now, 12132432, automobil, dobavljac);
    
    tvrtka.KnjigaNabave.Add(nabava);
    IPopust popust = PopustFactory.GetPopust();
    Prodaja prodaja = new Prodaja(DateTime.now, kupac, 50, popust, auto);
    Prodaja prodaja1 = new Prodaja(DateTime.now, kupac, 2343454, popust, auto);
    Prodaja prodaja2 = new Prodaja(DateTime.now, kupac, 32431432, popust, auto);

    tvrtka.KnjigaProdaje.add(prodaja);
    tvrtka.KnjigaProdaje.add(prodaja1);
    tvrtka.KnjigaProdaje.add(prodaja2);
    
    tvrtka.KnjigProdaje.Sort()
    forEach...

}
public class Automobil 
{
    public DateTime DatumProizvodnje {get;set;}
    public string BrojSasije {get;set;}
    public string Marka {get; set; }
    public string Model {get; set; }
    public int BrojSjedecihMjesta { get; set; }
    public int BrojVrata { get; set; }
    public int Snaga { get; set; }
    public List<Rezervoar> Rezervoari { get; set; }
    public Automobil(DateTime datumProizvodnje, ) // konstruktor koji ima sve properties
}
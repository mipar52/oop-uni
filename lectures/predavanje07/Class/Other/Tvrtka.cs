public class Tvrtka 
{
    public List<Prodaja> KnjigaProdaja;
    public List<Nabava> KnjigaNabava;
    public string Naziv { get; set; }
    public Tvrtka(string naziv) 
    { 
        this.Naziv = naziv;
        this.KnjigaProdaja = new List<Prodaja>();
        this.KnjigaNabava = new List<Nabava>();
    }
}
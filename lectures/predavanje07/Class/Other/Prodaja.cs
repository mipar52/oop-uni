public class Prodaja: IComparable<Prodaja>
{
    public DateTime Datum { get; set; }
    public Kupac Kupac { get; set; }
    public int Iznos { get; set; }
    public Automobil Automobil { get; set; }
    public IPopust Popust { get; set; }

    public int CompareTo(Prodaja other)
    {
        return -1 * this.Popust.IzracunajPopust(this.Iznos).CompareTo(other.Popust.IzracunajPopust(other.Iznos));
    }
    public override string ToString()
    {
        return $"Ime, Cijena: {Popust.IzracunajPopust(iznos)}kn, ..."

    }
}
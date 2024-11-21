public class VarijabilanPopust:IPopust
{
    public izracunajPopust(int cijena)
    {
        if (cijena < 100000) {
            return 0.97 * cijena;
        }
        return 0.93 * cijena;
    }
}
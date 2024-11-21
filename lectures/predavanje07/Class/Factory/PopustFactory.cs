public class PopustFactory 
{
    static IPopust GetPopust()
    {
        return new VarijabilniPopust();
    }

}
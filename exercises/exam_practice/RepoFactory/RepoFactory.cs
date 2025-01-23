namespace RepoFactory
{
    public class RepoFactory
    {
        public static IRepository GetRepository() => new FileRepository();
    }
}
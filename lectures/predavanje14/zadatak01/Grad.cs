namespace zadatak01
{
    public class Grad
    {
        public string Name { get; set; }
        public int Stanovnici { get; set; }

        public Grad(string name, int stanovnici)
        {
            Name = name;
            Stanovnici = stanovnici;
        }
    }
}
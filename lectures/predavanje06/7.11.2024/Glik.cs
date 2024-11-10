namespace Ucilica
{
    public abstract class Glik {
        protected Glik(string naziv, string boja) {
            naziv = naziv;
            boja = boja;
         }

         public string Naziv { get; set;}
         public string Boja { get; set;}
         public abstract string Povrsina();
         public abstract string Opseg();

    }

}
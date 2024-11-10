
namespace Predavanje04 

class Student {

    public string ime;
    public string prezime:
    public string jmbag;

    private int godinaStudija;
    public int GodinaStudija 
    { 
        get { return godinaStudija;}
        set 
        { 
            if ( value < 1 || value > 5) 
        {
            throw new Exception("Godina studija je neispravna!");
        } else
        {
            godinaStudija = value;
        }
        } 
     };

}


class Osoba  
{
    public string Ime  {get;set;}
    public string Prezime {get;set;}
    private string oib;
    public int GodinaStudija {get;set;}

    public Osoba(string ime, string prezime, string oib, int godinaStudija) 
    {
        this.Ime = ime;
        this.Prezime = prezime;
        this.Oib = oib;
        this.GodinaStudija = godinaStudija;
    }
    // zvanje konstuktora od gore (iz studenta) -> radimo default konstruktor
    public Osoba():this("000", "John", "Doe", "000", 0) {}
    override public string ToString() 
    {
        return oib + Ime + Prezime;
    }
}

class Profesor: Osoba
{
    public int BrojZnanosti  {get;set;}

    public Profesor(string oib, string ime, string prezime, int BrojZnanosti ):
    base(ime, prezime, oib)
    {
        this.BrojZnanosti = BrojZnanosti;
    }

        public override string ToString() 
    {
        // zvanje ToString od parenta
        // base je pointer na objekt Osoba -> 
        return $"{base.ToString()} broj znanstvenika: {BrojZnanosti}"
    }
    
}

class Student: Osoba
{
    public string Jmbag  { get; set; }

    private int godinaStudija

        public int GodinaStudija 
    { 
        get { return godinaStudija;}
        set 
        { 
            if ( value < 1 || value > 5) 
        {
            throw new Exception("Godina studija je neispravna!");
        } else
        {
            godinaStudija = value;
        }
        } 
     };

    public Student(int ime, string prezime, string oib, string jmbag, string):
    base(ime, ime, oib)
    {
        this.Jmbag = jmbag;
        this.GodinaStudija = godinaStudija
    }

    public override string ToString() 
    {
        // zvanje ToString od parenta
        return $"{base.ToString()} jmbag: {jmbag} godina studija {godinaStudija}"
    }

}

Student s1 = new Student("111", "Ana", "Horvat", "fff1", 1);
Student s1 = new Student("222", "Ana", "Horvat", "fff1", 2);
Profesor p1 = new Profesor("333", "Prof", "Baltazar", 1);

/******************************************************************************\
/**************************** Nasljedivanje **********************************\
/******************************************************************************\

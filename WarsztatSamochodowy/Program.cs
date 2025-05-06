using Zaklad;

internal class Program
{
    public static Warsztat Warsztat { get; set; }
    private static void Main(string[] args)
    {
        

        Warsztat warsztat = new Warsztat();

        warsztat.Nazwa = "Auto Serwis";
        warsztat.Adres = "ul. Mechaników 5, 00-001 Warszawa";
        warsztat.Telefon = "123-456-789";
        warsztat.Email="adam@wp.pl";
        warsztat.GodzinyOtwarcia = "Pon-Pt: 8:00-17:00, Sob: 9:00-14:00";

        
        Warsztat = Ustawienia(warsztat);
        
        WyswietlInformacje();
        Pomocnicze.Menu();
        
    }


    public static void WyswietlInformacje()
    {
        Console.WriteLine($"Nazwa: {Warsztat.Nazwa}");
        Console.WriteLine($"Adres: {Warsztat.Adres}");
        Console.WriteLine($"Telefon: {Warsztat.Telefon}");
        Console.WriteLine($"Email: {Warsztat.Email}");
        Console.WriteLine($"Godziny Otwarcia: {Warsztat.GodzinyOtwarcia}");
    }

    public static Warsztat Ustawienia(Warsztat warsztat)
    {
        Pracownik Adam=new Pracownik();
        Adam.Imie = "Adam";
        Adam.Nazwisko = "Kowalski";
        Adam.Adres = "ul. Mechaników 5, 00-001 Warszawa";
        Adam.Telefon = "123-456-789";
        Adam.Pensja=3500;
        Adam.stanowiskoPracownika=StanowiskoPracy.Właściciel;
        warsztat.dodajPracownika(Adam);

        return warsztat;
    }
}
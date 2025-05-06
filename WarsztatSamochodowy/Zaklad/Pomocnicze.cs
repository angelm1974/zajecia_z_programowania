using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using Zaklad;

internal static class Pomocnicze
{
    public static void Menu()
    {
        bool exit =false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Witaj w systemie zarządzania warsztatem!");
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("1. Dodaj pracownika");
            Console.WriteLine("2. Dodaj klienta");
            Console.WriteLine("3. Dodaj samochód");
            Console.WriteLine("4. Dodaj zlecenie");
            Console.WriteLine("5. Wyświetl pracowników");
            Console.WriteLine("6. Wyświetl klientów");
            Console.WriteLine("7. Wyświetl samochody");
            Console.WriteLine("8. Wyświetl zlecenia");
            Console.WriteLine("9. Wyjdź");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DodajPracownika();
                    break;
                case "2":
                    DodajKlienta();
                    break;
                case "3":
                    // Dodaj samochód
                    break;
                case "4":
                    DodajZlecenie();
                    break;
                case "5":
                    // Wyświetl pracowników
                    break;
                case "6":
                    // Wyświetl klientów
                    break;
                case "7":
                    // Wyświetl samochody
                    break;
                case "8":
                    // Wyświetl zlecenia
                    break;
                case "9":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                    Console.ReadKey();
                    break;
            }
        }

    }

    public static void DodajPracownika(){
        Console.Clear();
        Console.WriteLine("Dodaj pracownika");
        Console.Write("Imię: ");
        string imie = Console.ReadLine() ?? string.Empty;
        Console.Write("Nazwisko: ");
        string nazwisko = Console.ReadLine() ?? string.Empty;
        Console.Write("Adres: ");
        string adres = Console.ReadLine() ?? string.Empty;
        Console.Write("Telefon: ");
        string telefon = Console.ReadLine() ?? string.Empty;
        Console.Write("Email: ");
        string email = Console.ReadLine() ?? string.Empty;
        WyswietlStanowiska();
        int stanowisko = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Pensja: ");
        decimal pensja = decimal.Parse(Console.ReadLine() ?? string.Empty); 

        Pracownik nowyPracownik = new Pracownik(imie, nazwisko, adres, telefon, email, (StanowiskoPracy)stanowisko, pensja);
    
        Warsztat.Pracownicy.Add(nowyPracownik);
        Console.WriteLine($"Dodano pracownika: {nowyPracownik.Imie} {nowyPracownik.Nazwisko}");
        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
    }
    public static void WyswietlStanowiska()
    {
        Console.WriteLine("Wybierz stanowisko:");
        foreach (var stanowisko in Enum.GetValues(typeof(StanowiskoPracy)))
        {
            Console.WriteLine($"{(int)stanowisko}. {stanowisko}");
        }
    }

    public static void DodajKlienta()
    {
        Console.Clear();
        Console.WriteLine("Dodaj klienta");
        Console.Write("Imię: ");
        string imie = Console.ReadLine() ?? string.Empty;
        Console.Write("Nazwisko: ");
        string nazwisko = Console.ReadLine() ?? string.Empty;
        Console.Write("Adres: ");
        string adres = Console.ReadLine() ?? string.Empty;
        Console.Write("Telefon: ");
        string telefon = Console.ReadLine() ?? string.Empty;
        Console.Write("Email: ");
        string email = Console.ReadLine() ?? string.Empty;
        WyswietlTypKlienta();
        int typKlienta = int.Parse(Console.ReadLine() ?? string.Empty);

        Warsztat.Klienci.Add(new Klient(imie, nazwisko, adres, telefon, email, (typKlienta)typKlienta));
        Console.WriteLine($"Dodano klienta: {imie} {nazwisko}");   
        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();        
    }

    public static void WyswietlTypKlienta(){
        Console.WriteLine("Wybierz typ klienta:");
        foreach (var typ in Enum.GetValues(typeof(typKlienta)))
        {
            Console.WriteLine($"{(int)typ}. {typ}");
        }
    }

    public static void DodajZlecenie()
    {
        Console.Clear();
        Console.WriteLine("Dodaj zlecenie");
        Console.Write("Opis: ");
        string opis = Console.ReadLine() ?? string.Empty;
        Console.Write("Notatki: ");
        string notatki = Console.ReadLine() ?? string.Empty;
        Console.Write("Numer zlecenia: ");
        string numerZlecenia = Console.ReadLine() ?? string.Empty;
        Samochod mojsamochod = DodajSamochod();
        Zlecenie noweZlecenie = new Zlecenie("Nowe", notatki, numerZlecenia, mojsamochod);

    
        Warsztat.Zlecenia.Add(noweZlecenie);
        Console.WriteLine($"Dodano zlecenie: {opis}");
        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
    }

    public static void WyswietlTypZdarzenia()
    {
        Console.WriteLine("Wybierz typ zdarzenia:");
        foreach (var typ in Enum.GetValues(typeof(TypZdarzenia)))
        {
            Console.WriteLine($"{(int)typ}. {typ}");
        }
    }
    public static Samochod DodajSamochod()
    {
        Console.Clear();
        Console.WriteLine("Dodaj samochód");
        Console.Write("Marka: ");
        string marka = Console.ReadLine() ?? string.Empty;
        Console.Write("Model: ");
        string model = Console.ReadLine() ?? string.Empty;
        Console.Write("Kolor: ");
        string kolor = Console.ReadLine() ?? string.Empty;
        Console.Write("Rok produkcji: ");
        int rokProdukcji = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Numer rejestracyjny: ");
        string numerRejestracyjny = Console.ReadLine() ?? string.Empty;

        Samochod nowySamochod = new Samochod(marka, model, kolor, numerRejestracyjny, rokProdukcji);
        return nowySamochod;
        // Warsztat.Samochody.Add(nowySamochod);
        // Console.WriteLine($"Dodano samochód: {marka} {model}");
        // Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
    }
}

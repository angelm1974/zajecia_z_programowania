namespace Zaklad{

    public struct Warsztat
    {
        public static List<Pracownik> Pracownicy { get; set; } = new List<Pracownik>();
        public static List<Klient> Klienci { get; set; } = new List<Klient>();
        public static List<Zlecenie> Zlecenia { get; set; } = new List<Zlecenie>();
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string GodzinyOtwarcia { get; set; }

        public Warsztat(string nazwa, string adres, string telefon, string email, string godzinyOtwarcia)
        {
            Nazwa = nazwa;
            Adres = adres;
            Telefon = telefon;
            Email = email;
            GodzinyOtwarcia = godzinyOtwarcia;
        }

        public void dodajPracownika(Pracownik pracownik)
        {
            Pracownicy.Add(pracownik);
            Console.WriteLine($"Dodano pracownika: {pracownik.Imie} {pracownik.Nazwisko}");
        }

        public void dodajKlienta(Klient klient)
        {
            Klienci.Add(klient);
            Console.WriteLine($"Dodano klienta: {klient.Imie} {klient.Nazwisko}");
        }
        public  void usunPracownika(Pracownik pracownik)
        {
            Pracownicy.Remove(pracownik);
            Console.WriteLine($"Usunięto pracownika: {pracownik.Imie} {pracownik.Nazwisko}");
        }
        public void usunKlienta(Klient klient)
        {
            Klienci.Remove(klient);
            Console.WriteLine($"Usunięto klienta: {klient.Imie} {klient.Nazwisko}");
        }
    }
}
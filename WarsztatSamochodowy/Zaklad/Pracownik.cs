namespace Zaklad
{
    public struct Pracownik : Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public StanowiskoPracy stanowiskoPracownika { get; set; }
        public decimal Pensja { get; set; }

        public Pracownik(string imie, string nazwisko, string adres, string telefon, string email, StanowiskoPracy stanowisko, decimal pensja)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
            Telefon = telefon;
            Email = email;
            stanowiskoPracownika = stanowisko;
            Pensja = pensja;
        }
    }
    public enum StanowiskoPracy
    {
        Mechanik,
        Recepcjonista,
        Menedżer,
        Magazynier,
        Elektryk,
        Lakiernik,
        Blacharz,
        Diagnosta,
        Właściciel,
    }
}
namespace Zaklad
{
    public struct Klient(string imie, string nazwisko, string adres, string telefon, string email, typKlienta typKlienta) : Osoba
    {
        public string Imie { get; set; } = imie;
        public string Nazwisko { get; set; } = nazwisko;
        public string Adres { get; set; } = adres;
        public string Telefon { get; set; } = telefon;
        public string Email { get; set; } = email;
        public typKlienta TypKlienta { get; set; } = typKlienta;
    }
    public enum typKlienta
    {
        OsobaFizyczna,
        OsobaPrawna
    }
    
}
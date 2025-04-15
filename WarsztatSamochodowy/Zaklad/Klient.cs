namespace Zaklad
{
    public struct Klient : Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public typKlienta TypKlienta { get; set; }


    }
    public enum typKlienta
    {
        OsobaFizyczna,
        OsobaPrawna
    }
}
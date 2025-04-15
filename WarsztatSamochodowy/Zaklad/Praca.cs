namespace Zaklad
{
    public struct Praca
    {
        public Stanowisko ?stanowisko { get; set; }
        public DateTime ?DataRozpoczecia { get; set; }
        public DateTime ?DataZakonczenia { get; set; }
        public string ?Opis { get; set; }
        public decimal Koszt { get; set; }

    }
}
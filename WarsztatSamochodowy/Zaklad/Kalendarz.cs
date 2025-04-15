namespace Zaklad
{
    public struct Kalendarz
    {
        public int Id { get; set; }
        public string ?Zdarzenie { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataKoniec { get; set; }
        public TypZdarzenia ?Typ { get; set; }
        public Zlecenie ?zlecenie { get; set; }
        public Status ?Status { get; set; }

    }

    public enum TypZdarzenia
    {
        Rezerwacja,
        Naprawa,
        Diagnoza,
        Przeglad,
        Inne
    }

    public enum Status
    {
        Zrealizowane,
        W_trakcie,
        Anulowane,
        Oczekujace
    }
}
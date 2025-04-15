namespace Zaklad
{
    public struct Parking
    {
        List<Samochod> samochody = new List<Samochod>();
        public string Adres { get; set; }
        public int LiczbaMiejsc { get; set; }
        public int LiczbaWolnychMiejsc { get; set; }
        public string TypPojazdu { get; set; }

        public void zaparkujSamochod(Samochod samochod)
        {
            if (LiczbaWolnychMiejsc > 0)
            {
                samochody.Add(samochod);
                LiczbaWolnychMiejsc--;
            }
            else
            {
                Console.WriteLine("Brak wolnych miejsc na parkingu.");
            }
        }

        public void wyjedzSamochod(Samochod samochod)
        {
            if (samochody.Contains(samochod))
            {
                samochody.Remove(samochod);
                LiczbaWolnychMiejsc++;
            }
            else
            {
                Console.WriteLine("Samochód nie znajduje się na parkingu.");
            }
        }
        public void wyswietlSamochody()
        {
            Console.WriteLine("Samochody na parkingu:");
            foreach (var samochod in samochody)
            {
                Console.WriteLine($"Marka: {samochod.Marka}, Model: {samochod.Model}, Kolor: {samochod.Kolor}, Rejestracja: {samochod.Rejestracja}, Rok produkcji: {samochod.RokProdukcji}");
            }
        }
        public Parking(string adres, int liczbaMiejsc, int liczbaWolnychMiejsc, string typPojazdu)
        {
            Adres = adres;
            LiczbaMiejsc = liczbaMiejsc;
            LiczbaWolnychMiejsc = liczbaWolnychMiejsc;
            TypPojazdu = typPojazdu;
        }
    }
}
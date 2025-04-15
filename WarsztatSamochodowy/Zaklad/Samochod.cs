namespace Zaklad
{

    public struct Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Kolor { get; set; }
        public string Rejestracja { get; set; }
        public int RokProdukcji { get; set; }

        public Osoba ?wlasciciel { get; set; }

        public Samochod(string marka, string model, string kolor, string rejestracja, int rokProdukcji)
        {
            Marka = marka;
            Model = model;
            Kolor = kolor;
            Rejestracja = rejestracja;
            RokProdukcji = rokProdukcji;
        }

        public void Informacje()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Kolor: {Kolor}, Rejestracja: {Rejestracja}, Rok Produkcji: {RokProdukcji}");
            if (wlasciciel != null)
            {
                Console.WriteLine($"Właściciel: {wlasciciel.Imie} {wlasciciel.Nazwisko}");
            }
            else
            {
                Console.WriteLine("Brak informacji o właścicielu.");
            }
        }
}
}
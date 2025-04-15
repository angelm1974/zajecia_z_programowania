namespace Zaklad{



    public struct Zlecenie
    {
        public List<Praca> ?ListaPrac { get; set; }
        public int Id { get; set; }
        public string ?Status { get; set; }
        public string ?Notatka { get; set; }
        public string ?NumerZlecenia { get; set; }
        public Samochod samochod { get; set; }

        public void dodajPrace(Praca praca)
        {
            if (ListaPrac == null)
            {
                ListaPrac = new List<Praca>();
            }
            ListaPrac.Add(praca);
        }
        public void usunPrace(Praca praca)
        {
            if (ListaPrac != null && ListaPrac.Contains(praca))
            {
                ListaPrac.Remove(praca);
            }
        }

        public void wyswietlListePrac()
        {
            if (ListaPrac != null && ListaPrac.Count > 0)
            {
                foreach (var praca in ListaPrac)
                {
                    Console.WriteLine($"Stanowisko: {praca.stanowisko?.Nazwa}, Opis: {praca.Opis}, Koszt: {praca.Koszt}");
                }
            }
            else
            {
                Console.WriteLine("Brak prac w zleceniu.");
            }
        }
        public void ZlecenieInfo()
        {
            Console.WriteLine($"Numer Zlecenia: {NumerZlecenia}, Status: {Status}, Notatka: {Notatka}, Samochod: {samochod.Marka} {samochod.Model}");
        }
    }
}
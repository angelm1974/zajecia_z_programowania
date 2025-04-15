namespace Zaklad
{
    public struct Stanowisko
    {
        public string Nazwa { get; set; }
        public int Identyfikator { get; set; }

        public Stanowisko(string nazwa, int identyfikator)
        {
            Nazwa = nazwa;
            Identyfikator = identyfikator;
        }

    }
}
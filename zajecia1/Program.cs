internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5;  // Zmienna int przechowuje liczby całkowite
        int b = 8;
        int c = 0; // Zmienna int przechowuje liczby całkowite
        /*
        Console.WriteLine("Hello, World!");
        Console.WriteLine(2 + 4);
        Console.WriteLine("2 * 4");
        */
        Console.WriteLine($"wynik działania to: {2 * 4}");

        Console.WriteLine($"Minimal dla int: {int.MinValue}");

        Display("Dodaj zmienną a do b: " + (a + b));
        Console.WriteLine($"Dodaj zmienną a od b: {a+b}");
        Console.WriteLine($"Pokaż c: {c}");
        c = a + b * 2;
        Console.WriteLine($"Pokaż c: {c}");

        Display("Podaj wartość dla a: ");
        string ?text1 = Console.ReadLine();
        a = int.Parse(text1);

        Display("Podaj wartość dla b: ");
        string? text2 = Console.ReadLine();
        b = int.Parse(text2);

        Display($"Pokaż a: {a} + {b} = {a+b}");
    }

    static void Display(string arg)
    {
        Console.WriteLine(arg);
    }


}


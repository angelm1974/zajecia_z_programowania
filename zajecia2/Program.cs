using System.Net.Http.Headers;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Menu();
        //string ?wybor = Console.ReadLine();
        //WyborDzialania(wybor);
        //wyrazeniaSwitch3();
        //InstrWhile();
        //zalozFoldery();
        instrukcjaFor();
    }

#region Operatory
    private static void Dodawanie(int a, int b)
    {
        Console.WriteLine(a + b);
        Console.ReadKey();
    }  

    private static void Odejmowanie(int a, int b)
    {
        Console.WriteLine(a - b);
        Console.ReadKey();
    } 

    private static void Mnozenie(int a, int b)
    {
        Console.WriteLine(a * b);
        Console.ReadKey();
    }

    private static void Dzielenie(int a, int b)
    {
        Console.WriteLine(a / b);
        Console.ReadKey();
    }

    private static void Inkrementuj(int a)
    {
        a++;
        Console.WriteLine(a);
        Console.ReadKey();
    }

    private static void Dekrementuj(int a)
    {
        a--;
        Console.WriteLine(a);
        Console.ReadKey();
    }

    private static void Modulo1(int a, int b){
        Console.WriteLine(a % b);
        Console.ReadKey();
    }

    private static void LogicznyAnd(bool a, bool b){
        Console.WriteLine(a && b);
        Console.ReadKey();
    }
    //True && True = True   
    //True && False = False
    //False && True = False
    //False && False = False

    private static void LogicznyOr(bool a, bool b){
        Console.WriteLine(a || b);
        Console.ReadKey();
    }
    //True || True = True
    //True || False = True
    //False || True = True
    //False || False = False

    private static void LogicznyXor(bool a, bool b){
        Console.WriteLine(a ^ b);
        Console.ReadKey();
    }
    //True ^ True = False
    //True ^ False = True
    //False ^ True = True
    //False ^ False = False

    private static void LogicznyNot(bool a){
        Console.WriteLine(!a);
        Console.ReadKey();
    }
    //!True = False
    //!False = True

    private static void BitowyAnd(int a, int b){
        Console.WriteLine(a & b);
        Console.ReadKey();
    }
    // 0 & 0 = 0
    // 0 & 1 = 0
    // 1 & 0 = 0
    // 1 & 1 = 1

    private static bool ZrobCos(){
        Console.WriteLine("Robie cos");
        return true;
    }

    private static void ZrobCos2(){
        bool a = true;
        Console.WriteLine($"a & ZrobCos() = {a & ZrobCos()}");
        Console.WriteLine($"a & ZrobCos() = {a && ZrobCos()}");
        Console.ReadKey();
    }
#endregion

#region Sterowanie
    private static void Wybierz(int a){
        if (a == 1)
        {
            Console.WriteLine("a jest rowne 1");
        }
        else if (a == 2)
        {
            Console.WriteLine("a jest rowne 2");
        }
        else if (a == 3)
        {
            Console.WriteLine("a jest rowne 3");
        }
        else
        {
            Console.WriteLine("a nie jest rowne 1, 2 ani 3");
        }
        Console.ReadKey();
}

    private static void Wybierz2(int a){
        switch (a)
        {
            case 1:
                Console.WriteLine("a jest rowne 1");
                break;
            case 2:
                Console.WriteLine("a jest rowne 2");
                break;
            case 3:
                Console.WriteLine("a jest rowne 3");
                break;
            case 759:
                Console.WriteLine("otwierają się drzwi");
                break;
            default:
                Console.WriteLine("a nie jest rowne 1, 2 ani 3");
                break;
        }
        Console.ReadKey();
    }
    private static void Wyswietl(string tekst){
        Console.WriteLine(tekst);
    }

    private static int pobierzINT(string tekst){
        Console.WriteLine(tekst);
        string ?input = Console.ReadLine();
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input), "Input cannot be null");
        }
        return int.Parse(input);
    }   
    private static void Menu(){
        string tekst = "1. Dodawanie\n2. Odejmowanie\n3. Mnozenie\n4. Dzielenie\n5. Inkrementacja\n6. Dekrementacja\n7. Modulo\n8. Logiczny And\n9. Logiczny Or\n10. Logiczny Xor\n11. Logiczny Not\n12. Bitowy And\n13. Zrob Cos\n14. Wybierz\n15. Wyswietl\n16. Menu\n17. Wyjscie";
        Wyswietl(tekst);
    }



    private static void WyborDzialania(string ?wybor){
        switch (wybor)
        {
            case "1":
                Dodawanie(pobierzINT("podaj a"), pobierzINT("podaj b"));
                break;
            case "2":
                Odejmowanie(5, 3);
                break;
            case "3":
                Mnozenie(5, 3);
                break;
            case "4":
                Dzielenie(5, 3);
                break;
            case "5":
                Inkrementuj(5);
                break;
            case "6":
                Dekrementuj(5);
                break;
            case "7":
                Modulo1(5, 3);
                break;
            case "8":
                LogicznyAnd(true, false);
                break;
            case "9":
                LogicznyOr(true, false);
                break;
            case "10":
                LogicznyXor(true, false);
                break;
            case "11":
                LogicznyNot(true);
                break;
            case "12":
                BitowyAnd(5, 3);
                break;
            case "13":
                ZrobCos2();
                break;
            case "14":
                Wybierz(1);
                break;
            case "15":
                Wyswietl("Hello, World!");
                break;
            case "16":
                Menu();
                break;
            case "17":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Nie ma takiej opcji");
                break;
        }
    }

    private static void wyrazeniaSwitch(string liczba){
        
        string wynik = liczba switch
        {
            "1" => "jeden",
            "2" => "dwa",
            "3" => "trzy",
            _ => "inna liczba"
        };
        Console.WriteLine(wynik);
    }

    private static void wyrazeniaSwitch2(){
        object obj="Cześć";
        string wynik = obj switch
        {
            int i => "To jest liczba",
            string s => "To jest string",
            _ => "To jest inny typ"
        };
        
        Console.WriteLine(wynik);
    }

    private static void wyrazeniaSwitch3(){
        int liczba = 4;
        string wynik = liczba switch
        {
            var x when x < 0 => "liczba ujemna",
            var x when x > 0 => "liczba dodatnia",
            0 => "zero",
            _ => "błąd"
        };
        Console.WriteLine(wynik);
    }
#endregion

private static void InstrWhile(){
    int i = 0;
    while (i < 10)
    {
        Console.WriteLine(i);
        i++;
    }
}

private static void InstrDoWhile(){
    
    int i = 0;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i < 10);
}

private static void zalozFoldery(){
    string sciezka_main =@"D:\Programy\PODSTAWY_PROGRAMOWANIA\zajecia2\bin\Debug";
    DateTime data = DateTime.Now;
    string rok = data.Year.ToString();
    string miesiac = data.Month.ToString();
    string dzien = data.Day.ToString();

    int i=0;
    do
    {

        string sciezka = rok + "-" + miesiac + "-" + dzien;
        Directory.CreateDirectory(sciezka_main + "\\" + sciezka);
        i++;
        dzien = data.AddDays(i).Day.ToString();
    } while (i < 10);
}


private static void instrukcjaFor(){
    for (int i = 10; i > 0; i-=5)
    {
        Console.WriteLine(i);
    }
}

private static void instrukcjaForeach(){
    string[] tablica = {"jeden", "dwa", "trzy", "cztery"};
    foreach (var item in tablica)
    {
        Console.WriteLine(item);
    }
}
}
namespace Oppgave_uke_1;

class Program
{
    // Her er en funksjon som tar inn to tall og returnerer summen av de to tallene.
    public static int MyIntMethod(int a, int b)
    {
        return a + b;
    }

    /* Her er en funksjon som ber brukeren om å skrive inn navnet sitt og returnerer en hilsen til brukeren.
     Jeg har brukt en while loop for å sjekke om brukeren har skrevet inn et navn.
     Hvis brukeren ikke har skrevet inn et navn vil brukeren få en feilmelding, og må skrive navnet på nytt før koden avsluttes */
    public static string UserGreetings()
    {
        while (true)
        {
            Console.WriteLine("Hello, please enter your name: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter your name!");
                continue;
            }
            else
            {
                return "Hello " + name + "!";
            }
        }
    }

    static void Main(string[] args)
    {
        // Jeg har kommentert ut disse linjene så slipper jeg å få warnings i konsollen siden de ikke er brukt.
        // Jeg har brukt Console.WriteLine(); for å skille mellom de forskjellige oppgavene.
        // int a = 5;
        // string a_string = "Hei";
        // double b = 3.14;
        // char c = 'A';

        // Jeg har brukt en for loop for å skrive ut alle elementene i arrayet.
        int[] tallrekke = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < tallrekke.Length; i++)
        {
            Console.WriteLine($"iterator {i} på tallrekke: {tallrekke[i]} ");
        }

        Console.WriteLine();
        Console.WriteLine();

        // Jeg har brukt en foreach loop for å skrive ut alle elementene i arrayet.
        string[] biler = { "Volvo", "BMW", "Ford", "Mazda" };

        foreach (string bil in biler)
        {
            Console.WriteLine(bil);
        }
        // Jeg har laget en liste og legger til frukt.
        List<string> frukt = new List<string>();
        frukt.Add("Eple");
        frukt.Add("Pære");
        frukt.Add("Banan");
        frukt.Add("Appelsin");
        frukt.Add("Kiwi");
        frukt.Add("Drue");

        Console.WriteLine();

        // Jeg har brukt en foreach loop for å skrive ut alle elementene i listen frukt.
        foreach (string fruktNavn in frukt)
        {
            Console.WriteLine(fruktNavn);
        }

        Console.WriteLine();

        // Jeg har brukt My Int Method for å legge sammen to tall og skrive ut resultatet.
        Console.WriteLine(MyIntMethod(5, 10));
        Console.WriteLine();

        // Jeg har brukt en Dictionary for å legge til elementer og skrive ut alle elementene i myDictionary.
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        myDictionary.Add(1, "Hei");
        myDictionary.Add(2, "på");
        myDictionary.Add(3, "deg");
        myDictionary.Add(4, "og");
        myDictionary.Add(5, "hade");
        myDictionary.Add(6, "på");
        myDictionary.Add(7, "badet!");

        // Jeg har brukt en foreach loop for å skrive ut alle elementene i Dictionary.
        foreach (var word in myDictionary)
        {
            Console.Write(word.Value + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        // Jeg har brukt UserGreetings for å skrive ut en hilsen til brukeren.
        Console.Write(UserGreetings());
    }
}

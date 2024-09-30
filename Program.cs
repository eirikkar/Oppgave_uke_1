namespace Oppgave_uke_1;

class Program
{
    public static int MyIntMethod(int a, int b)
    {
        return a + b;
    }

    public static string UserGreetings()
    {
        Console.WriteLine("Hello, please enter your name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            return "Please use a valid name";
        }
        else
        {
            return "Hello " + name + "!";
        }
    }

    static void Main(string[] args)
    {
        int a = 5;
        string a_string = "Hei";
        double b = 3.14;
        char c = 'A';
        int[] tallrekke = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < tallrekke.Length; i++)
        {
            Console.Write(tallrekke[i]);
        }

        string[] biler = { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine();
        foreach (string bil in biler)
        {
            Console.WriteLine(bil);
        }

        List<string> frukt = new List<string>();
        frukt.Add("Eple");
        frukt.Add("Pære");
        frukt.Add("Banan");
        frukt.Add("Appelsin");
        frukt.Add("Kiwi");
        frukt.Add("Drue");
        Console.WriteLine();

        foreach (string fruktNavn in frukt)
        {
            Console.WriteLine();
            Console.WriteLine(fruktNavn);
        }
        Console.WriteLine();
        Console.WriteLine(MyIntMethod(5, 10));

        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        myDictionary.Add(1, "Hei");
        myDictionary.Add(2, "på");
        myDictionary.Add(3, "deg");
        myDictionary.Add(4, "og");
        myDictionary.Add(5, "hade");
        myDictionary.Add(6, "på");
        myDictionary.Add(7, "badet!");

        foreach (var word in myDictionary)
        {
            Console.Write(word.Value + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(UserGreetings());
    }
}

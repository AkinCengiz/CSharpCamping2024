using System.Runtime.InteropServices;
using MaskTracking.Business.Concrete;

namespace WorkArround;

internal class Program
{
    static void Main(string[] args)
    {
        //Variables();

        Person person = new()
        {
            IdentityNumber = 11111111111,
            FirstName = "Akın",
            LastName = "Cengiz",
            BirthYear = 1981
        };
        SayHi("Akın");
        SayHi("Cengiz");
        SayHi("Beşiktaş");
        SayHi();

        string student1 = "Akın";
        string student2 = "Aytaç";
        string student3 = "Ali";

        string[] students = {student1, student2, student3};

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Öğrenci {i + 1} -> {students[i]}");
        }

        string[] cities1 = new[] { "İstanbul", "Ankara", "İzmir" };
        string[] cities2 = new[] { "Çanakkale","Edirne", "Kocaeli" };

        Console.WriteLine("\n----------------CITY 1-----------------");
        foreach (var city in cities1)
        {
            Console.WriteLine(city);
        }
        Console.WriteLine("\n----------------CITY 2-----------------");
        foreach (var city in cities2)
        {
            Console.WriteLine(city);
        }

        cities2 = cities1;
        cities1[2] = "Nevşehir";

        Console.WriteLine("\n----------------CITY 2-----------------");
        foreach (var city in cities2)
        {
            Console.WriteLine(city);
        }

        List<string> citiesList = new List<string>();
        citiesList.Add("Eskişehir");
        citiesList.Add("Sakarya");
        citiesList.Add("Şanlıurfa");
        citiesList.Add("Diyarbakır");

        Console.WriteLine("\n----------------COLLECTION CITIES-----------------");
        foreach (var city in citiesList)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine();
        Console.WriteLine(Add());
        Console.WriteLine(Add(1903));

        PttManager pttManager = new PttManager(new ForeignerManager());
        pttManager.GiveMask(person);

        Console.ReadLine();
    }

    public static void SayHi(string name = "No Name")
    {
        Console.WriteLine($"Merhaba {name}");
    }


    public static int Add(int number1 = 0, int number2 = 1903)
    {
        return number1 + number2;
    }

    private static void Variables()
    {
        string message = "Merhaba";
        double total = 10000;
        int number = 100;
        bool isLogin = false;

        SayHi("Akın CENGİZ");

        string firstName = "Akın";
        string lastName = "Cengiz";
        int birthYear = 1981;
        long identityNumber = 11111111111;
        Console.WriteLine(total * 1.18);
    }
}

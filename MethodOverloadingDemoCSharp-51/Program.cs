namespace MethodOverloadingDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        var added = Add(2.5, 2.5);
        Console.WriteLine(added);

        Console.WriteLine("Give me your first name:");
        var firstName = Console.ReadLine();

        Console.WriteLine("Give me your last name:");
        var lastName = Console.ReadLine();

        Console.WriteLine("Give me your age:");
        var age = int.Parse(Console.ReadLine());
        
        //Greet("Seth");
        Greet(firstName, lastName, age);
    }

    public static int Add(int numOne, int numTwo)
    {
        return numOne + numTwo;
    }

    public static double Add(double numOne, double numTwo)
    {
        return numOne + numTwo;
    }

    public static void Greet(string firstName)
    {
        Console.WriteLine($"Hello, {firstName}!");
    }

    public static void Greet(string firstName, string lastName)
    {
        Console.WriteLine($"Hello, {firstName} {lastName}");
    }

    public static void Greet(string firstName, string lastName, int age)
    {
        if (age >= 21)
        {
            Console.WriteLine($"Hello {firstName} {lastName}, you can drink at this event.");
        }
        else
        {
            Console.WriteLine($"Hello {firstName} {lastName}, you cannot drink at this event.");
        }
    }
}

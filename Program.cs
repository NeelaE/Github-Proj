
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[]args)
    {
       
        Console.WriteLine(Printer(5, 5));
        Console.WriteLine(Printer(15, 5));
        Console.WriteLine(Printer(5, 5));

    }

    public static int Printer(int a, int b)
    {
        int c = a + b;
        return c;

    }
}

    
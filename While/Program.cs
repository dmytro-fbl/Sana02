using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool good;
        int n;
        do
        {
            Console.WriteLine("Введіть число n");
            good = int.TryParse(Console.ReadLine(), out n);
            if (!good || n < 0)
                Console.WriteLine("Ви ввели не правильну умову числа");

        } while (!good || n < 0);

        Console.WriteLine("Вираз №1");
        ExpresionOne(n);
        Console.WriteLine();
        Console.WriteLine("Вираз №2");
        ExpresionTwo(n);
        Console.WriteLine();
        Console.WriteLine("Вираз №3");
        ExpresionThird(n);
        Console.WriteLine();

    }
    public static void ExpresionOne(int n)
    {
        double sum = 0;
        double a = 0;
        for(int i = 1; i <= n; i++)
        {
            a = Math.Pow((-1), i) / (2 * i + 1);
            sum += a;
            Console.WriteLine($"{sum:F2}");
        }
    }

    public static void ExpresionTwo(int n)
    {
        double sum = 0;
        double b = 0;
        for (int i = 1; i <= n; i++)
        {
            b = (1 + (1 / Math.Pow(i, 2)));
            sum += b;
            Console.WriteLine($"{sum:F2}");
        }
    }
    public static void ExpresionThird(int n)
    {
        double sum = 0;
        double c = 1;
        for (int i = 1; i <= n; i++)
        {
            c *= i;
            sum += c;
            
            Console.WriteLine($"{sum:F2}");
        }
    }


}
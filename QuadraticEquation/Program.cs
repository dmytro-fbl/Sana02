internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double a, b, c, D;
        bool good;
        do
        {
            Console.WriteLine("введіть число а");
            good = double.TryParse(Console.ReadLine(), out a);
            if (!good)
                Console.WriteLine("Ви ввели не число");
        } while (!good);
        do
        {
            Console.WriteLine("введіть число b");
            good = double.TryParse(Console.ReadLine(), out b);
            if (!good)
                Console.WriteLine("Ви ввели не число");
        } while (!good);
        do
        {
            Console.WriteLine("введіть число c");
            good = double.TryParse(Console.ReadLine(), out c);
            if (!good)
                Console.WriteLine("Ви ввели не число");
        } while (!good);
        if (a == 0)
        {
            Console.WriteLine("число А = 0 тому це не є квадратне рівняння"); 
            return;
        }
        D = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine($"Дискримінант: {D:F2}");
        if (D < 0)
        {
            Console.WriteLine("Розв'язків немає");
        }else if (D > 0)
        {
            double x1, x2;
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"Корінь рівняння №1: {x1}");
            Console.WriteLine($"Корінь рівняння №2: {x2}");
        }else if (D == 0)
        {
            double x1 = -b / (2 * a);
            Console.WriteLine($"Корінь рівняння №1: {x1}");
        }
    }
}
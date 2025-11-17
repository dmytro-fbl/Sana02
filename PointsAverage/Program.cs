internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int numberGrades = 5;
        bool good;
        int[] arrcount = new int[numberGrades];
        double averVal = 0;
        int sumVal = 0;

        Console.WriteLine("Введіть оцінки студентів");
        for(int i = 0; i < numberGrades;  i++)
        {
            do
            {
                Console.WriteLine($"Оцінка №{i + 1}");
                good = int.TryParse(Console.ReadLine(), out arrcount[i]);
                if (!good || arrcount[i] < 0 || arrcount[i] > 100)
                    Console.WriteLine("Помилка числа");
            }while(!good || arrcount[i] < 0 || arrcount[i] > 100);
            sumVal += arrcount[i];
        }

        averVal = sumVal / numberGrades;
        Console.WriteLine($"Середній бал {averVal:F2}");

        if (averVal < 50)
            Console.WriteLine("Студент не допущений до екзамену");
        else
            Console.WriteLine("Студент допущений до екзамену");
        
    }
}
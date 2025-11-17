internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int numberGrades;
        bool good;
        do
        {
            Console.WriteLine("Введіть скільки чисел ви хочете записати");
            good = int.TryParse(Console.ReadLine(), out numberGrades);
            if (!good || numberGrades <= 0)
                Console.WriteLine("Не коректне число");
        } while (!good || numberGrades <= 0);

        int[] ints = new int[numberGrades];
        
        for (int i = 0; i < numberGrades; i++)
        {
            do
            {
                Console.WriteLine("Введіть числа");
                good = int.TryParse(Console.ReadLine(), out ints[i]);
                if (!good || ints[i] < 0 || ints[i] > 9)
                    Console.WriteLine("невірне число");
            } while (!good || ints[i] < 0 || ints[i] > 9);

            switch (ints[i])
            {
                case -1:
                    Console.WriteLine("Вихід з програми");
                    return;
                case 0:
                    Console.WriteLine("0 - нуль");
                    break;
                case 1:
                    Console.WriteLine("1 - один");
                    break;
                case 2:
                    Console.WriteLine("2 - два");
                    break;
                case 3:
                    Console.WriteLine("3 - три");
                    break;
                case 4:
                    Console.WriteLine("4 - чотири");
                    break;
                case 5:
                    Console.WriteLine("5 - п'ять");
                    break;
                case 6:
                    Console.WriteLine("6 - шість");
                    break;
                case 7:
                    Console.WriteLine("7 - сім");
                    break;
                case 8:
                    Console.WriteLine("8 - вісім");
                    break;
                case 9:
                    Console.WriteLine("9 - дев'ять");
                    break;
                default:
                    Console.WriteLine("число не входить в даниий діапазон");
                    break;
                

            }
        }
        

        
        
    }
}
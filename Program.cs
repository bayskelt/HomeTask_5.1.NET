using System.Runtime.InteropServices;

namespace HomeTask_5._1.NET
{
    internal class Program
    {
        static void Avarage(decimal n1, decimal n2)
        {
            decimal avarage = (n1 + n2) / 2;
            Console.Write($"Середнє арифметичне цих чисел: {avarage}");
        }
        static void Main()
        {
            Console.Write("Введiть перше цiле число: ");
            int x = int.Parse(s: Console.ReadLine());
            Console.Write("Введiть друге цiле число: ");
            int y = int.Parse(s: Console.ReadLine());

            Avarage( x, y );
        }
    }
}

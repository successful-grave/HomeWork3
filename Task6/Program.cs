using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую сторону а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третью сторону c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                if ((a + b > c) && (a + c > b) && (b + c > a))
                {
                    Console.WriteLine("Треугольник существует");
                }
                else
                {
                    Console.WriteLine("Треугольник не существует");
                }
            }
            else
            {
                Console.WriteLine("Сторона не может отрицательной или равной нулю");
            }
        }
    }
}

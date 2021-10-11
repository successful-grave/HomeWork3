using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine($"{A} + {B} = {A + B}");
            }
            else
            {
                if(A == B)
                {
                    Console.WriteLine($"{A} * {B} = {A * B}");
                }
                else
                {
                    Console.WriteLine($"{A} - {B} = {A - B}");
                }
            }
        }
    }
}

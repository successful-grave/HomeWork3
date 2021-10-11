using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Квадратное уравнение: " +
                $"{A}x^2 {B.ToString("+#;-#;0")}x {C.ToString("+#;-#;0")} = 0");

            double Discriminate = Math.Pow(B, 2) - 4 * A * C;
            if(Discriminate > 0)
            {
                double x1 = (-B + Math.Sqrt(Discriminate)) / 2 * A;
                double x2 = (-B - Math.Sqrt(Discriminate)) / 2 * A;
                Console.WriteLine($"Корни уравнения: x1 = {x1}\t\tx2 = {x2}");
            }
            else if (Discriminate == 0)
            {
                double x = -B / 2 * A;
                Console.WriteLine($"Корень уравнения: x = {x}");
            }
            else
            {
                Console.WriteLine("Корней нет при отрицательном дискриминанте");
            }
        }
    }
}

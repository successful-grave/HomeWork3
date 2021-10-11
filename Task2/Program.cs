using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Х: ");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            if(X > 0 && Y > 0)
            {
                Console.WriteLine("Точка находится в первой четверти");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Точка находится во второй четверти");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Точка находится в третьей четверти");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Точка находится в четвёртой четверти");
            }
            else if (X == 0 && Y > 0)
            {
                Console.WriteLine("Точка находится на оси ординат между 1 и 4 четвертями");
            }
            else if (X == 0 &&  Y < 0)
            {
                Console.WriteLine("Точка находится на оси ординат между 2 и 3 четвертями");
            }
            else if (X < 0 && Y == 0)
            {
                Console.WriteLine("Точка находится на оси абцисс между 3 и 4 четвертями");
            }
            else if (X > 0 && Y == 0)
            {
                Console.WriteLine("Точка находится на оси абцисс между 1 и 2 четвертями");
            }
            else if (X == 0 && Y == 0)
            {
                Console.WriteLine("Точка находится в начале координат (0; 0)");
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}

using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 10 || number >= 100)
            {
                Console.WriteLine("Ошибка ввода. Число должно быть двухзначным");
            }
            else
            {
                if (number == 10)
                {
                    Console.WriteLine("Десять");
                }
                else if (number == 11)
                {
                    Console.WriteLine("Одиннадцать");
                }
                else if (number == 12)
                {
                    Console.WriteLine("Двенадцать");
                }
                else if (number == 13)
                {
                    Console.WriteLine("Тринадцать");
                }
                else if (number == 14)
                {
                    Console.WriteLine("Четырнадцать");
                }
                else if (number == 15)
                {
                    Console.WriteLine("Пятнадцать");
                }
                else if (number == 16)
                {
                    Console.WriteLine("Шестнадцать");
                }
                else if (number == 17)
                {
                    Console.WriteLine("Семнадцать");
                }
                else if (number == 18)
                {
                    Console.WriteLine("Восемнадцать");
                }
                else if (number == 19)
                {
                    Console.WriteLine("Девятнадцать");
                }
                else if (number == 20 || number / 10 == 2)
                {
                    Console.Write("Двадцать");
                }
                else if (number == 30 || number / 10 == 3)
                {
                    Console.Write("Тридцать");
                }
                else if (number == 40 || number / 10 == 4)
                {
                    Console.Write("Сорок");
                }
                else if (number == 50 || number / 10 == 5)
                {
                    Console.Write("Пятьдесят");
                }
                else if (number == 60 || number / 10 == 6)
                {
                    Console.Write("Шестьдесят");
                }
                else if (number == 70 || number / 10 == 7)
                {
                    Console.Write("Семьдесят");
                }
                else if (number == 80 || number / 10 == 8)
                {
                    Console.Write("Восемьдесят");
                }
                else if (number == 90 || number / 10 == 9)
                {
                    Console.Write("Девяносто");
                }
                if (number % 10 == 1)
                {
                    Console.Write(" один");
                }
                else if (number % 10 == 2)
                {
                    Console.Write(" два");
                }
                else if (number % 10 == 3)
                {
                    Console.Write(" три");
                }
                else if (number % 10 == 4)
                {
                    Console.Write(" четыре");
                }
                else if (number % 10 == 5)
                {
                    Console.Write(" пять");
                }
                else if (number % 10 == 6)
                {
                    Console.Write(" шесть");
                }
                else if (number % 10 == 7)
                {
                    Console.Write(" семь");
                }
                else if (number % 10 == 8)
                {
                    Console.Write(" восемь");
                }
                else if (number % 10 == 9)
                {
                    Console.Write(" девять");
                }
                Console.WriteLine();
            }
        }
    }
}

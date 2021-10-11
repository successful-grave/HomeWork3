using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Андрей, ответь, пожалуйста, в телеграме (t.me/gravemoren) или классруме,
            //как можно здесь тернарным оператором проверить все условия на проверку одинаковых чисел
            //и тд, чтобы это было читаемо? Я просто мозг сломал, но так и не придумал как это можно
            //в один тернарный засунуть, чтобы это было читаемо
            Console.Write("Введите число А: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            if(A < B && B < C)
            {
                Console.WriteLine($"Числа по возрастанию: {A} {B} {C}");
            }
            else if (B < A && A < C)
            {
                Console.WriteLine($"Числа по возрастанию: {B} {A} {C}");
            }
            else if (C < A && A < B)
            {
                Console.WriteLine($"Числа по возрастанию: {C} {A} {B}");
            }
            else if (B < C && C < A)
            {
                Console.WriteLine($"Числа по возрастанию: {B} {C} {A}");
            }
            else if (C < B && B < A)
            {
                Console.WriteLine($"Числа по возрастанию: {C} {B} {A}");
            }
            else if (A == B && A < C)
            {
                Console.WriteLine($"Числа по возрастанию: {A} {B} {C}");
            }
            else if (A == C && B > A)
            {
                Console.WriteLine($"Числа по возрастанию: {A} {C} {B}");
            }
            else if (B == C && A > C)
            {
                Console.WriteLine($"Числа по возрастанию: {C} {B} {A}");
            }
            else if (A == C && B < A)
            {
                Console.WriteLine($"Числа по возрастанию: {B} {A} {C}");
            }
            else // A == B == C
            {
                Console.WriteLine($"Числа по возрастанию: {A} {B} {C}");
            }
        }
    }
}

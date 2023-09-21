using System;

namespace Tymakov_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упр.2_1 Пользователь вводит имя, программа приветствует по имени
            Console.WriteLine("Упр.2_1 Пользователь вводит имя, программа приветствует по имени!");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, {0}!", name);
            //Упр. 2_2 Вывести на экран результат деления введенных двух целых чисел, учесть деление на 0
            int n1, n2;
            Console.WriteLine("Упр. 2_2 Вывести на экран результат деления введенных двух целых чисел, учесть деление на 0");
            Console.Write("Введите первое целое число: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 != 0)
                Console.WriteLine($"Результат: {n1/n2}");
            else
                Console.WriteLine("На ноль делить нельзя!");
            /*Дом. задание 2.1:Прочитать букву с экрана и вывести на печать следующую за ней
            букву в алфавитном порядке.*/
            Console.WriteLine("Дом. задание 2.1:Прочитать букву с экрана и вывести на печать следующую за ней\r\n            букву в алфавитном порядке.");
            Console.Write("Введите букву: ");
            string letter = Console.ReadLine();
            if (letter == "z")
                Console.WriteLine("a");
            if (letter == "я")
                Console.WriteLine("a");
            else
            {
                char next_letter = Convert.ToChar(letter);
                Console.WriteLine(Convert.ToChar(next_letter + 1));
            }
            /*2.2 Написать программу, которая решает квадратное уравнение.
             * Входные данные – коэффициенты уравнения, выходные – найденные корни.*/
            Console.WriteLine("Написать программу, которая решает квадратное уравнение.\r\n              Входные данные – коэффициенты уравнения, выходные – найденные корни.");
            double a, b, c, diskr, sqrt_diskr, x1, x2;
            Console.Write("Введите коэффициент а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            c = Convert.ToDouble(Console.ReadLine());
            diskr = b * b - 4 * a * c;
            sqrt_diskr = Math.Sqrt(diskr);
            if (diskr < 0)
            {
                Console.WriteLine("Уравнение не имеет корней.");
            }
            if (diskr == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine($"Уравнение имеет 1 корень:{x1}");
            }
            if (diskr > 0)
            {
                x1 = ((-b) + sqrt_diskr) / (2 * a);
                x2 = ((-b) - sqrt_diskr) / (2 * a);
                Console.WriteLine($"Уравнение имеет 2 корня: {x1} и {x2}");
            }
        }  

    }
}

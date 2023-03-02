using System;

namespace _10
{
    class Program
    {
        // Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Напишите программу, в которой создайте метод, который в качестве аргумента принимает целое
        //число и определяет количество разрядов данного числа.Пользователь должен иметь
        //возможность вводит число с клавиатуры
        static void Discharges(int number){
            if (number > 0 && number <=9)
            {
                Console.WriteLine("Ваше число попало в первый разряд - " + number);
            }
            else if(number > 10 && number <= 99)  
            {
                Console.WriteLine("Ваше число попало в второй разряд - " + number);
            }
            else if (number > 100 && number <= 999)
            {
                Console.WriteLine("Ваше число попало в третий разряд - " + number);
            }
            else if (number > 1000 && number <= 9999)
            {
                Console.WriteLine("Ваше число попало в четвертый разряд - " + number);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число = ");
            int number = int.Parse(Console.ReadLine());
            Discharges(number);
        }
    }
}

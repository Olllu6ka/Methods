using System;

namespace Methods
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Напишите программу в которой создайте метод, который принимает в качестве параметров три
        //целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов.

       
        static void Main(string[] args)
        {
            void Arifmetika(int a, int b, int c)
            {
                Console.WriteLine((a + b + c) / 3);

            }

            int number = 0, number1 = 0,number2 = 0;
            Console.Write("Введите число 1 = ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Введите число 2 = ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число 3 = ");
            number2 = int.Parse(Console.ReadLine());
            Arifmetika(number, number1, number2);
            
        }
    }
}

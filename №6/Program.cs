using System;

namespace _6
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Напишите программу, в которой создайте метод, который принимает в качестве параметров три
        //целочисленных значения и возвращает значение каждого аргумента, умноженного на 10.
        //(Использовать out и ref)
        static void Multiplication(ref int number, ref int number1, ref int number2)
        {
            number = number * 10;
            number1 = number1 * 10;
            number2 = number2 * 10;
            return;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число 1 = ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите число 2 = ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число 3 = ");
            int number2 = int.Parse(Console.ReadLine());
            Multiplication(ref number,ref number1,ref number2);
            Console.WriteLine(number+ " " + number1 + " " + number2 );
            
        }
    }
}

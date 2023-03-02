using System;

namespace _2
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Напишите программу в которой создайте метод, который в качестве аргументов принимает 2
        //числа и возвращает меньшее из них.
        static void Main(string[] args)
        {
            int SmallerNumber (int number2,int number3)
            {
                if (number2 < number3)
                {
                    return number2;
                }
                else if (number3 < number2)
                {
                    return number3;
                }
                return 0;
            }

            int number, number1;
            Console.Write("Введите число п1 =");
            number = int.Parse(Console.ReadLine());
            Console.Write("Введите число п2 =");
            number1 = int.Parse(Console.ReadLine());
            SmallerNumber(number, number1);
        }
    }
}

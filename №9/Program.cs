using System;

namespace _9
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Напишите программу, которая будет вычислять сумму цифр числа N.Число N пользователь
        //должен вводить с клавиатуры. При решении этой задачи нельзя использовать строки, списки,
        //массивы (ну и циклы, разумеется). (Использовать рекурсию)
        static void NumbersN (int number){
            Console.WriteLine(number + number);
            NumbersN(number);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число N = ");
            int number = int.Parse(Console.ReadLine());
            NumbersN(number);

            // Если я сделал не правильно то напишите в телегам )
            // seller_ip 
        }
    }
}

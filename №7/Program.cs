using System;

namespace _7
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Написать программу, в которой создайте один метод, который будет вычислять площадь и
        //периметр прямоугольника.Сторони прямоугольника пользователь должен иметь возможность
        //вводит с клавиатуры.
        static void Rectangle(ref int number,ref int number1){
            Console.WriteLine(number*number1 + " - Площадь прямоугольника ");
            Console.WriteLine(2 * (number+number1) + " - Периметр прямоугольника");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первую сторону прямоугольника в см = ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите первую сторону прямоугольника в см = ");
            int number1 = int.Parse(Console.ReadLine());
            Rectangle(ref number, ref number1);
        }
    }
}

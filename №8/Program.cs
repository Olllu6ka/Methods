using System;

namespace _8
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Напишите программу, в которой создайте метод, который выведет все числа от 1 до N.N – число
        //которое пользователь вводит с клавиатуры. (Использовать рекурсию)
        static void Number(int number,int number1){
            number1++;
            Console.WriteLine(number1);
            if (number1 != number)
            {
                Number(number, number1); 
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число до какого вы хотите сделать вывод = ");
            int number = int.Parse(Console.ReadLine());
            Number(number,0);
        }
    }
}

using System;

namespace _3
{
    class Program
    {
        //. Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Создайте программу, в которой создайте метод, который принимает в качестве аргумента год
        //рождения пользователя и возвращает его полный возраст.
        static void Main(string[] args)
        {
            void Year (int year, int DateNow )
            {
                Console.WriteLine(DateNow - year + " - Ваш возраст" );
            }
            DateTime date = DateTime.Now;
            int CurrentYear = date.Year;
            Console.Write("Введите ваш год рождения = ");
            int yearperson = int.Parse(Console.ReadLine());
            Year(yearperson, CurrentYear);

        }
    }
}

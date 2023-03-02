using System;

namespace _5
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Напишите программу для конвертирования валюты.Пользователь должен иметь возможность
        //ввести курс валюты, в которую он хочет конвертировать, сумму которую он хочет
        //конвертировать.Программа должна вывести сумму денег в соответствующей валюте.
        static void Usd(double number1,double number2,string function)
        {
            if (function == "Uah")
            {
                number1 = 36.5367;
            }
            else if (function == "Eur")
            {
                number1 = 0.94811;
            }
            else if (function == "Try")
            {
                number1 = 18.7604;
            }
            Console.WriteLine("USD = " + function + " - " + (number1 * number2));
        }
        static void UAH(double number1,double number2,string function)
        {
            if (function == "Usd")
            {
                number1 = 0.0272;
            }
            else if (function == "Eur")
            {
                number1 = 0.02558;
            }
            else if (function == "Try")
            {
                number1 = 0.50606;
            }
            Console.WriteLine("UAH = " + function + " - " + (number1 * number2));
        }
        static void Eur(double number1, double number2, string function)
        {
            if (function == "Usd")
            {
                number1 = 1.05448;
            }
            else if (function == "Uah")
            {
                number1 = 38.5273;
            }
            else if (function == "Try")
            {
                number1 = 19.7824;
            }
            Console.WriteLine("EUR = " + function + " - " + (number1 * number2));
        }
        static void Try(double number1, double number2, string function)
        {
            if (function == "Usd")
            {
                number1 = 0.05267;
            }
            else if (function == "Uah")
            {
                number1 = 1.92428;
            }
            else if (function == "Eur")
            {
                number1 = 0.04993;
            }
            Console.WriteLine("TRY = " + function + " - " + (number1 * number2));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите вашу валюту (Uah,Eur,Try,Usd) = ");
            string Function = Console.ReadLine();
            Console.Write("Сколько валюты у вас,введите число = ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите валюту в которую хотите конвертировать  (Uah,Eur,Try,Usd) = ");
            string Function1 = Console.ReadLine();
            if (Function == "Uah")
            {
                UAH(0, number, Function1);
            }
            else if (Function == "Usd")
            {
                Usd(0, number, Function1);
            }
            else if (Function == "Eur")
            {
                Eur(0, number, Function1);
            }
            else if (Function == "Try")
            {
                Try(0, number, Function1);
            }

        }
    }
}

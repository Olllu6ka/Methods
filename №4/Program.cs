using System;

namespace _4
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Напишите программу консольный калькулятор.В данной программе должны быть четыре
        //метода, метод для сложения, вычитания, умножения и деления.Каждый из методов должен
        //принимать 2 целочисленных аргумента и выполнять соответствующею действие. Метод для
        //деления должен выполнять проверку деления на ноль.Также необходимо предоставить
        //пользователю возможность вводить знак арифметической операции, в зависимости от знака
        //вызывать соответствующий метод.Также пользователю необходимо предоставить возможность
        //вводит значения аргументов. 
        static void Addition(int number,int number1)
        {
            Console.WriteLine("Вы сложили два числа = " + (number+number1));
        }
        static void Subtraction(int number,int number1,int function)
        {
            if (function == 1)
            {
                Console.WriteLine("Вы вычитали два числа = " + (number - number1));
            }
            else if (function == 2)
            {
                Console.WriteLine("Вы вычитали два числа = " + (number1 - number));
            }
        }
        static void Multiplication(int number,int number1)
        {
            Console.WriteLine("Вы умножили два числа = " + (number * number1));
        }
        static void Division( int number,int number1, int function)
        {
            Console.WriteLine("Выберите с каким числом вы хотите выполнить действие - с первым то 1, с вторым то 2");
            if (function == 1)
            {
                if (number1 == 0)
                {
                    Console.WriteLine("Делить на ноль нельзя !");
                }
                Console.WriteLine("Вы поделили два числа = " + (number / number1));
                
            }
            else if (function == 2)
            {
                if (number == 0)
                {
                    Console.WriteLine("Делить на ноль нельзя !");
                }
                Console.WriteLine("Вы поделили два числа = " + (number1 / number));
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число = ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число = ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите действие которое вы хотите сделать (+,-,*,/) = ");
            string Function = Console.ReadLine();
            switch (Function)
            {
                case "+":
                    Addition(number,number1);
                    break;
                case "-":
                    Console.WriteLine("Выберите с каким числом вы хотите выполнить действие - с первым то 1, с вторым то 2");
                    int function = int.Parse(Console.ReadLine());
                    Subtraction(number,number1,function);
                    break;
                case "*":
                    Multiplication(number, number1);
                    break;
                default:
                    Console.WriteLine("Выберите с каким числом вы хотите выполнить действие - с первым то 1, с вторым то 2");
                    int function1 = int.Parse(Console.ReadLine());
                    Division(number, number1, function1);
                    break;
            }

        }
    }
}

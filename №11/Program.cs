using System;

namespace _11
{
    class Program
    {
       //Используя Visual Studio, создайте проект по шаблону Console Application. 
       //Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли
       // клиент кредит или нет.Допустим, ежемесячная сумма платежа должна составлять 100 грн.
       //Клиент должен выполнить 7 платежей, но может платить реже большими суммами.Т.е., может
       //двумя платежами по 300 и 400 грн.Закрыть весь долг.

        //Можно дорабоатть 
       static void Credit( ref double PersonCredit, ref double MoneyGive){
            if (PersonCredit > MoneyGive)
            {
                PersonCredit = PersonCredit - MoneyGive;
                Console.WriteLine(PersonCredit + " - Кредит человка");
            }
            else if ( MoneyGive >= PersonCredit)
            {
                Console.WriteLine(" - Кредит выплачен !") ;
                if (MoneyGive > PersonCredit)
                {
                    Console.WriteLine("Клиент переплатил банку - " + (MoneyGive - PersonCredit));
                }
                PersonCredit = 0;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите кредит вашего клиента в грн = ");
            double Creditperson = int.Parse(Console.ReadLine());
            Console.Write("Сколько ваш клиент должен сделать платижей по вашому договору = ");
            double Payments = int.Parse(Console.ReadLine());
            Console.Write("Ваш клиент должен вносить каждый месяц в ваш банк денег - " + (Creditperson / Payments) + " грн");
            int Payment = 1, PaymentNot = 1;
            for (;;)
            {
                
                Console.Write("\nСколько ваш клиент сделал платижей в этом месяце = ");
                double PaymentsPerson = int.Parse(Console.ReadLine());
                if (PaymentsPerson >= 1)
                {
                    for (int i = 0; i < PaymentsPerson; i++)
                    {
                        Console.Write("Введите " + Payment + " платеж клиента в грн = ");
                        Payment++;
                        double MoneyGive = int.Parse(Console.ReadLine());
                        Credit(ref Creditperson, ref MoneyGive);
                        if (Creditperson == 0)
                        {
                            break;
                        }
                    }
                }
                else if (PaymentsPerson == 0)
                {
                    Console.WriteLine("Предупредить что он не оплатил " + PaymentNot + " месяц и должен сделать " + (PaymentNot+1) + " платежа подряд");
                    PaymentNot++;
                    if (Payments < PaymentNot)
                    {
                        Console.WriteLine("\nКлиент просрочил сдачу кредита ! " + "Просрочка на " + Creditperson);
                        Creditperson = 0;
                        break;
                       
                    }
                }
                if (Creditperson == 0)
                {
                    break;
                }
            }
        }
    }
}

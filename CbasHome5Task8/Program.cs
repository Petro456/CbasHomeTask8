using System;

namespace CbasHome5Task8
{
    internal class Program
    {
        /*Задание 5

        Используя Visual Studio, создайте проект по шаблону Console Application. 
        Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить
        количество дней до его следующего дня рождения.*/
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime birthday;
            TimeSpan wait;

            Console.WriteLine("Введiть дату свого народження 'рiк, мiсяць, день'");
            birthday = Convert.ToDateTime(Console.ReadLine());

            
            DateTime thisYear = new DateTime(now.Year, birthday.Month, birthday.Day);

            if (thisYear < now)
            {
                thisYear = new DateTime(now.Year + 1, birthday.Month, birthday.Day);
                wait = thisYear - now;
            }
            else
            {
                wait = thisYear - now;
            }           
            Console.WriteLine("Ваш день народження настане через " + wait.Days + " днiв");
            Console.ReadKey();
        }
    }
}

using System;
                    // Не впевнений що правильно, але ніби працює. Хоча якщо робити ще залежність скільки годин перепрацьовано із вирахування погодинної оплтаи то треба міняти програму
namespace CbasHome3Task7
{
    enum Posada
    {
        worker=160,
        foreman=155,
        manager =140,
        direktor = 170
    }

    class Accountant
    {

       public bool AskForBonus(Posada postWorker, int hours)
        {
            if ((int)postWorker < hours)
            {
                Console.WriteLine("Працiвник  " + postWorker + "  перепрацював  " + (hours-(int)postWorker) +"  годин"+ " - отримає премiю!");
                return true;
            }
            else return false;
           
        }

    }

    internal class Program
    {
        /*Задание 3

        Используя Visual Studio, создайте проект по шаблону Console Application. 
        Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
        Присвойте каждой константе значение, задающее количество часов, 
        которые должен отработать сотрудник за месяц. Создайте класс Accountant с методом
        bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию. 
        Если сотрудник отработал больше положенных часов в месяц, то ему положена премия.*/
        static void Main(string[] args)
        {
            Accountant ask = new Accountant();

            Console.WriteLine(ask.AskForBonus(Posada.worker, 170));
            Console.WriteLine(ask.AskForBonus(Posada.foreman, 160));
            Console.WriteLine(ask.AskForBonus(Posada.manager, 150));
            Console.WriteLine(ask.AskForBonus(Posada.direktor, 180));

            Console.ReadKey();
        }
    }
}

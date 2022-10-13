using System;

namespace CbasHomeTask8
{

    static class ConsolePrinter
    {
        public enum OutputColors { Blue = 9, Green = 10, Red = 12 }

        public static void Print(string text, OutputColors outputColor)
        {
            Console.ForegroundColor = (ConsoleColor)Convert.ToInt32(outputColor);
            Console.WriteLine(text);
        }
    }
    internal class Program
    {
        /*Задание 2 

            Используя Visual Studio, создайте проект по шаблону Console Application. 
        Создайте статический класс с методом void Print (string stroka, int color), 
        который выводит на экран строку заданным цветом. Используя перечисление, создайте набор цветов,
        доступных пользователю. Ввод строки и выбор цвета предоставьте пользователю. */
        static void Main(string[] args)
        {
            ConsolePrinter.Print("Red color", ConsolePrinter.OutputColors.Red);
            ConsolePrinter.Print("Green color", ConsolePrinter.OutputColors.Green);
            ConsolePrinter.Print("Blue color", ConsolePrinter.OutputColors.Blue);

            Console.ReadKey(true);
        }
    }
}

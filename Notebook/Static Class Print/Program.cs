//Создайте статический класс с методом void Print(string stroka, int color), который выводит на экран
//строку заданным цветом.Используя перечисление, создайте набор цветов, доступных пользователю.Ввод
//строки и выбор цвета предоставьте пользователю.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your text: ");
            string text = Console.ReadLine();
            Console.WriteLine(@"Color for the line:   
        red = 1,
        yellow = 2,
        blue = 3,
        black = 4,
        white = 5,
        green = 6,
        gray = 7");
            int color;
            int.TryParse(Console.ReadLine(), out color);

            Service.Print(text, color);
            Console.Read();
        }
    }

    enum Colors
    {
        red = 1,
        yellow = 2,
        blue = 3,
        black = 4,
        white = 5,
        green = 6,
        gray = 7
    }
    static class Service
    {
        public static void Print(string stroka, int color)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            switch (color)
            {
                case (int)Colors.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Colors.yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Colors.blue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case (int)Colors.black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case (int)Colors.white:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case (int)Colors.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
            Console.WriteLine(stroka);
        }
    }
}

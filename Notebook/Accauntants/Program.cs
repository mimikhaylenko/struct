//Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
//Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за
//месяц.
//Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать
//или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему положена
//премия.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accauntants
{
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            if(accauntant.AskForBonus(Post.Director, 40))
            Console.WriteLine("Good job! Take your money!");
            else
                Console.WriteLine("Sorry, not this time");
            Console.WriteLine("--------------------------------");
            if (accauntant.AskForBonus(Post.Programmer, 400))
                Console.WriteLine("Good job! Take your money!");
            else
                Console.WriteLine("Sorry, not this time");
            Console.ReadKey();
        }
    }
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
                return true;
            else return false;
        }
    }
    enum Post
    {
        Director = 80,
        Manager = 290,
        Tester = 300,
        Programmer = 320,
        BA = 250
    }
}

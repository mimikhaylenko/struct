using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook_1 = new Notebook("A5", "Shkolyarik", 10);
            Notebook notebook_2 = new Notebook("A2", "Shkolyarik", 7);

            notebook_1.ShowInfo();
            notebook_2.ShowInfo();

            Console.Read();
        }
    }
    struct Notebook
    {
        string model;
        string maker;
        decimal price;

        public Notebook(string model, string maker, decimal price)
        {
            this.model = model;
            this.maker = maker;
            this.price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"model: {model}, maker: {maker}, price: {price}");
        }
    }
}

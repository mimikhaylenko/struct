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
            Train[] trains = new Train[8];

            trains[0] = new Train("London", 111, "10:00 PM");
            trains[1] = new Train("Paris", 222, "02:00 PM");
            trains[2] = new Train("Moscow", 999, "11:00 PM");
            trains[3] = new Train("Bratislava", 888, "08:00 PM");
            trains[4] = new Train("Sophia", 555, "10:00 AM");
            trains[5] = new Train("Berlin", 666, "02:10 AM");
            trains[6] = new Train("Madrid", 777, "03:40 AM");
            trains[7] = new Train("Zagreb", 444, "06:00 AM");

            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine("Input information about " + (i+1) + "th train:");
            //    Console.WriteLine("Destination:");
            //    string destination = Console.ReadLine();
            //    Console.WriteLine("number of train:");
            //    int N = int.Parse(Console.ReadLine());
            //    Console.WriteLine("time:");
            //    string time = Console.ReadLine();
            //    trains[i] = new Train(destination, N, time);
            //}
            Console.WriteLine("Before sort");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(trains[i]);
            }
            Train train1 = trains[0];
            for (int i = 0; i < 7; i++)
                for (int j = i + 1; j < 8; j++)
                {
                    if (trains[i].Number > trains[j].Number)
                    {
                        train1 = trains[i];
                        trains[i] = trains[j];
                        trains[j] = train1;
                    }
                }
            Console.WriteLine("After sort:");
            for (int i = 0; i < 8; i++)
            {
                    Console.WriteLine(trains[i]);
            }
            Console.WriteLine("Enter number of train: ");
            int number = int.Parse(Console.ReadLine());
            bool trainExists = false;
            for (int i = 0; i < 8; i++)
            {
                if (trains[i].Number == number)
                {
                    Console.WriteLine(trains[i]);
                    trainExists = true;
                }
            }
            if(!trainExists)
                Console.WriteLine("Wrong number of train!");
            Console.ReadLine();
        }
    }
    struct Train
    {
        string destination;
        int number;
        string departureTime;

        public int Number { get => number; }
        public Train(string destination, int number, string departureTime)
        {
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
        }
        public override string ToString()
        {
            return $"The train (N{number}) to {destination} will depart at {departureTime}";
        }
    }
}

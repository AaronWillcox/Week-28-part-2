using System;

namespace Week_28_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("YE0 T0DD", "Ford", "Fiesta");
            TPSolutions.AddCar(c1);

            Ticket t1 = new Ticket(c1, 75.0, 14);
            TPSolutions.AddTicket(t1);

            Console.WriteLine(c1);
            Console.WriteLine(t1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Week_28_part_2
{
    static class TPSolutions
    {
        public static List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public static List<Car> Cars { get; set; } = new List<Car>();


        public static void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public static void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Week_28_part_2
{
    class Ticket
    {
        public Guid Id { get; set; }

        public Car Car { get; set; }

        public DateTime Date { get; set; }

        public double Fee { get; set; }

        public int DaysToPay { get; set; }

        public bool Paid { get; set; }

        public Ticket(Car car, double fee, int daysToPay)
        {
            Id = Guid.NewGuid();
            Car = car;
            Date = DateTime.Now;
            Fee = fee;
            DaysToPay = daysToPay;
            Paid = false;
        }

        public override string ToString()
        {
            return $@"
Id: {Id} 
Car: {Car} 
Date: {Date} 
Fee: {Fee} 
DaysToPay: {DaysToPay} 
Paid: {Paid}";
        }
    }
}

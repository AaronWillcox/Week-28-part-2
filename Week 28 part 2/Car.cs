using System;
using System.Collections.Generic;
using System.Text;

namespace Week_28_part_2
{
    class Car
    {
        
        public string Reg { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
        
        public Car(string reg, string make, string model)
        {
            Reg = reg;
            Make = make;
            Model = model;
        }

        public override string ToString()
        {
            return $"Reg: {Reg} Make: {Make} Model: {Model}";
        }

    }
}

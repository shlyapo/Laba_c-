using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Shlyapo_4
{
    public class Employee
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public bool OnWeekend { get; set; }
        public bool Married { get; set; }
        public int Age { get; set; }
        public Employee()
        { }
        public Employee(string Name, int Cost, bool OnWeekend, bool Married, int Age)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.OnWeekend = OnWeekend;
            this.Married = Married;
            this.Age = Age;
        }

        public void ShowInf()
        {
            Console.WriteLine($"Name:{Name} Cost:{Cost} On Weekend:{OnWeekend} Married:{Married} Age:{Age}");

        }
    }
}

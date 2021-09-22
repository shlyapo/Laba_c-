using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Шляпо_Lab5
{
    class Trafic
    {
        public int Value { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }
        public Trafic(int Value, int Cost, string Name)
        {
            this.Cost = Cost;
            this.Value = Value;
            this.Name = Name;
        }
    }
}

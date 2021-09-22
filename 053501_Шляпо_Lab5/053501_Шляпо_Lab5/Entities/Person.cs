using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Шляпо_Lab5
{
    class Person
    {
        public string Name { get; set; }
        public Trafic Res { get; set; }
        public int Sum { get; set; }
        public Person(string Name, Trafic Res, int Sum){
            this.Name = Name;
            this.Res = Res;
            this.Sum = Sum;
        }
        public Person(string Name){
            this.Name = Name;
        }
        public void Registration(Trafic Res, int Sum){
            this.Res = Res;
            this.Sum = Sum;

        }

    }
}

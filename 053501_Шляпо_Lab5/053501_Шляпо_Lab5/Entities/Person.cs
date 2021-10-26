using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Шляпо_Lab5
{
    class Person
    {
        public string Name { get; set; }
        //public Trafic Res { get; set; }
        //public string NameTr { get; set; }
        public Trafic Traf{ get; set; }

        public int SumT{ get; set; }
        public Person(string Name, Trafic Traf, int Sum){
            this.Name = Name;
            this.Traf = Traf;
            this.SumT = Sum;
        }
        public Person(string Name){
            this.Name = Name;
        }
        public void Registration(Trafic Traf, int Sum){

            this.Traf = Traf;
            this.SumT = Sum;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}

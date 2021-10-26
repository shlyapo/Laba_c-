using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Шляпо_Lab5
{
    class Trafic
    {
        public int Cost { get; set; }
        public string NameTr { get; set; }
        //public string Traf { get; set; }
        public int SumTr{ get; set; }
        public Trafic(int Cost, string Name)
        {
            this.Cost = Cost;
            this.NameTr = Name;
            //this.Traf = Name;
        }
         //public int SumTraf(int Traf)
        //{
            //this.SumTr +=Cost;
            //return SumTr;
        //}
        public override string ToString()
        {
            return NameTr;
        }
    }
}

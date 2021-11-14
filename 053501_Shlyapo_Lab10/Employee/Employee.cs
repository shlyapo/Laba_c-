using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeee
{
    public class Employee
    {
        public int Age { get; set; }
        public bool OnWeekend { get; set; }
        public string Name { get; set; }
        Employee() { }
        public Employee(string Name)
        {
            this.Name = Name;
        }
        public Employee(string Name, int Age, bool OnWeekend)
        {
            this.Name = Name;
            this.Age = Age;
            this.OnWeekend = OnWeekend;
        }
    }
}

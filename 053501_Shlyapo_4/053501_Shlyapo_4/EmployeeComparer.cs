using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Shlyapo_4
{
    public class EmployeeComparer_Employee : IComparer<Employee>
    {
        public EmployeeComparer_Employee()
        {
        }
        public int Compare(Employee p1, Employee p2)
        {
            return p1.Name.CompareTo(p2.Name);
        }
    }
}

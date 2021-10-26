using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace _053501_Shlyapo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee> ();
            Employee p1 = new Employee("Liza", 3000, true, true, 32);
            Employee p2 = new Employee("Maria", 3000, true, true, 31);
            Employee p3 = new Employee("Stas", 3000, true, true, 37);
            Employee p4 = new Employee("Alena", 3000, true, true, 35);
            Employee p5 = new Employee("Nastya", 3000, true, true, 39);
            Employee p6 = new Employee("Ann", 3000, true, true, 30);
            emp.Add(p1);
            emp.Add(p2);
            emp.Add(p3);
            emp.Add(p4);
            emp.Add(p5);
            emp.Add(p6);
            //string path = @"\h.txt";
            //FileInfo fileInf = new FileInfo(path);
            //if (fileInf.Exists)
           // {
                //ileInf.Delete();
                // альтернатива с помощью класса File
                // File.Delete(path);
           // }
            FileService t = new FileService();
            t.SaveData(emp, "./h.txt");
            File.Move("./h.txt", "new");
            List<Employee> data2 = new List<Employee>(t.ReadFile("new"));
            foreach (var s in emp)
            {
                s.ShowInf();
            }
            Console.WriteLine();
            var l= data2.OrderBy(s => s, new EmployeeComparer_Employee());
            foreach (var i in l)
            {
                i.ShowInf();
            }
        }
    }
}
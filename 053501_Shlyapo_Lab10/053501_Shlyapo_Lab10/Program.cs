using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employeee;
using FileService;
using System.Reflection;

namespace _053501_Shlyapo_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Employee> emp= new List<Employee>();
            Employee p1 = new Employee("Ann", 19, true);
            Employee p2 = new Employee("Maria", 20, false);
            Employee p3 = new Employee("Stas", 23, true);
            Employee p4 = new Employee("Liza", 19, true);
            Employee p5 = new Employee("Nastya", 18, false);
            Employee p6 = new Employee("Nick", 29, false);
            emp.Add(p1);
            emp.Add(p2);
            emp.Add(p3);
            emp.Add(p4);
            emp.Add(p5);
            emp.Add(p6);
            try
            {
                Assembly asm = Assembly.LoadFrom("FileService.dll");

                Type t = asm.GetType("FileService.FileService", true, true);

                // создаем экземпляр класса Program
                object obj = Activator.CreateInstance(t);

                // получаем метод GetResult
                MethodInfo method1 = t.GetMethod("SaveData");

                MethodInfo method2 = t.GetMethod("ReadFile");
                // вызываем метод, передаем ему значения для параметров и получаем результат
                object result = method1.Invoke(obj, new object[] { emp, "result.txt"});
                object result2 = method1.Invoke(obj, new object[] { "result.txt"});
                Console.WriteLine((result2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

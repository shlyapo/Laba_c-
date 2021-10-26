using System;
using System.Collections.Generic;

namespace _053501_Шляпо_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string,Trafic> traf = new Dictionary<string,Trafic>();
            Trafic traf1 = new Trafic(100, "Medlenno");
            Trafic traf2 = new Trafic(160, "Sredne");
            Trafic traf3 = new Trafic(250,"Bistro");

            Person pers1 = new Person("perviy", traf1, 500);
            Person pers2 = new Person("vtoroi", traf2, 600);
            Person pers3 = new Person("tretiy", traf3, 800);
            Firma database = new Firma();

            database.Add<Person>(pers1);
            database.Add<Person>(pers2);
            database.Add<Person>(pers3);
            database.Add<Trafic>(traf1);
            database.Add<Trafic>(traf2);
            database.Add<Trafic>(traf3);

            var del = new Journal();
            //database.NotifyList += del.RegistrationEvent;
            //database.NotifyRegistr += (string about, string name) =>
            //{
                //Console.WriteLine(about);
                //Console.WriteLine(name);
            //};
            Person pers4 = new Person("Olga");
            database.Add<Person>(pers4);

            //del.Info();
            //database.RegistrationTrafic(pers4, traf1, 500);
            database.TarifsNames();
            Console.WriteLine(database.ToSum());
            database.TarifsClient();
            Console.WriteLine(database.Client());
            Console.WriteLine(database.More(600));
            database.Sum();
        }
    }
}

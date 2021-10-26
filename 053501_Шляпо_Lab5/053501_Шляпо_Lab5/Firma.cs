using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _053501_Шляпо_Lab5
{
    class Firma
    {
        List<Person> person = new List<Person>();
        Dictionary<string, Trafic> res = new Dictionary<string, Trafic>();
        List<Person> myTraf = new List<Person>();
        //public int Value { get; set; }
        public delegate void Del(string about, string name);
        public event Del NotifyList;
        public event Del NotifyRegistr;

        public Firma()
        { }
        public string NameValue { get; set; }
        public Firma(string name)
        {
            this.NameValue = name;
        }
        public void Add<T>(T temp) where T : class
        {
            if (temp is Person)
            {
                Person a = temp as Person;
                person.Add(a);
                NotifyList?.Invoke("add Person", a.Name);

            }
            else if (temp is Trafic)
            {
                Trafic a = temp as Trafic;
                res.Add(a.NameTr, a);
                NotifyList?.Invoke("add Trafic", a.NameTr);
            }

            else
            {
                throw new InvalidCastException();
            }
        }
        //public void SumPers(int a, Trafic Name, Person Name)
        //{

        //}
        public void RegistrationTrafic(Person a, Trafic Traf, int S)
        {
            a.Registration(Traf, S);
            NotifyRegistr?.Invoke("add Trafic", Traf.NameTr);
        }

        public void InfPerson()
        {
            for (int i = 0; i < person.Count; i++)
            {
                Console.WriteLine(person[i].Name);
            }
        }

        //public void InfTarifs()
        //{
        //for (int i = 0; i < person.Count; i++)
        //{
        //Console.WriteLine(res[i].Cost);
        //}
        // }

        public void TarifsNames()//первый метод1
        {
            var names = from i in res
                        orderby i.Value.Cost
                        select i;
            foreach (var j in names)
            {
                Console.WriteLine(j.Value.NameTr);
            }

        }

        public void TarifsClient()//метод 3
        {
            var sum = person.Where(l => l.Name != null).GroupBy(i => i.Traf);
              foreach (var g in sum)
              {
                  foreach (var j in g)
                  {
                     Console.WriteLine(j.Traf);

                  }
              }
        }
        public void Inc(string Names, int sum)
        {
            Person temp;
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].Name == Names)
                {
                    temp = person[i];
                    temp.SumT += sum;
                }

                throw new Exception("person not found");
            }
        }

        public void Sum()//последний метод6
        {
            var sum = person.Where(l => l.Name!= null).GroupBy(i => i.SumT);
            foreach (var g in sum)
            {
                foreach (var j in g)
                {
                    Console.WriteLine(j.SumT);
                }
            }
        }

        public int More(int sum)//5
        {
            int result = person.Where(t => t.SumT >= sum).Count();
            return result;
        }

        public int ToSum()//общая стоимость2
            {
                int totalSum = 0;
                for (int i = 0; i < person.Count; i++)
                {
                    totalSum += person[i].SumT;
                }
                return totalSum;
            }



        public string Client()//макс4
        {
            string name = person.Where(i => i.SumT != 0).OrderBy(j => j.SumT).Select(i => i.Name).Last();
            return name;
        }
    }
}

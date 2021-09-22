using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Шляпо_Lab5
{
    class Firma
    {
        public MyCustomCollection<Person> peo = new MyCustomCollection<Person>();
        public MyCustomCollection<Trafic> tafs = new MyCustomCollection<Trafic>();

        public delegate void Del(string about, string name);
        public event Del NotifyList;
        public event Del NotifyRegistration;

        public void Add<T>(T temp) where T : class
        {
            if (temp is Person)
            {
                Person a = temp as Person;
                peo.Add(a);
                NotifyList?.Invoke("add Person", a.Name);

            }
            else if (temp is Trafic)
            {
                Trafic a = temp as Trafic;
                tafs.Add(a);
                NotifyList?.Invoke("add Trafic", a.Name);
            }
            else
            {
                throw new InvalidCastException();
            }
        }

        public void RegistrationTrafic(Person a, Trafic Value, int Sum)
        {
            a.Registration(Value, Sum);
            NotifyRegistration?.Invoke("add Value", Value.Name);
        }

        public void InfPerson()
        {
            for (int i = 0; i < peo.Count; i++)
            {
                Console.WriteLine(peo[i].Name);
            }
        }

        public void InfTarifs()
        {
            for (int i = 0; i < tafs.Count; i++)
            {
                Console.WriteLine(tafs[i].Cost);
            }
        }

        public void Inc(string Names, int sum)
        {
            Person temp;
            for (int i = 0; i < peo.Count; i++)
            {
                if (peo[i].Name == Names)
                {
                    temp = peo[i];
                    temp.Sum += sum;
                }
            }
            throw new Exception("person not found");
        }

        public int ToSum()
        {
            int totalSum = 0;
            for (int i = 0; i < peo.Count; i++)
            {
                totalSum += peo[i].Sum;
            }
            return totalSum;
        }
    }
}

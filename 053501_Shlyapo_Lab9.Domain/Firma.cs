using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace _053501_Shlyapo_Lab9.Domain
{
    [Serializable]
    public class Firma
    {
        public string Name { get; set; }
        public List<Otdel> People;

        public Firma() { }
        public Firma(string Name)
        {
            this.Name = Name;
            People = new List<Otdel>();
        }
        public Firma(string Name, List<Otdel> p)
        {
            this.Name = Name;
            People = p;
        }
    }
}

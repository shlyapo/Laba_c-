using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrumental
{
    public class MusicInstrumental
    {
        public string NameOfInstrumental { get; set; }
        public string Country { get; set; }
        public int Cost { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public MusicInstrumental[] data;
        bool dateIsNotNull = false;
        public MusicInstrumental()
        {
        }
        public MusicInstrumental(int number)
        {
            data = new MusicInstrumental[number];
        }
        public MusicInstrumental(int cost, int age, string color, string country)
        {
            Country = country;
            Cost = cost;
            Age = age;
            Color = color;
        }
        public MusicInstrumental this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Название:{NameOfInstrumental} Возраст: {Age} Стоимость: {Cost} Страна: {Country} ");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(string.Format("{0} {1}, {2}", NameOfInstrumental, Country, Color.ToString()));

            if (dateIsNotNull)

            {

                output.Append(string.Format("Date of birth: {0}", Cost));

                output.AppendLine(string.Format(" ({0} years)", Age));

            }

            return output.ToString();

        }
    }
}
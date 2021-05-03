using System;
using System.Collections.Generic;
using System.Text;

namespace instrumental
{
    abstract class Keyboard : MusicInstrumental
    {
        public int CountOfKey { get; set; }
        public string HighSound { get; set; }
        public string LowSound { get; set; }
        public virtual int Weight { get; set; }
        public Keyboard(int count, string high, string low, int weight)
            : base()
        {
            CountOfKey = count;
            HighSound = high;
            LowSound = low;
            Weight = weight;
        }
        public Keyboard(int count, string high, string low, int number, int weight)
            :base(number)
        {
            CountOfKey = count;
            HighSound = high;
            LowSound = low;
            Weight = weight;
        }
        public Keyboard(int count, string high, string low, int cost, int age, string color, string country, int weight)
            : base(cost, age, color, country)
        {
            CountOfKey = count;
            HighSound = high;
            LowSound = low;
            Weight = weight;
        }

        public abstract void Play(int time);
        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendLine();
            output.AppendLine(string.Format("{0} {1}, {2}", HighSound, LowSound.ToString()));
            output.AppendLine(string.Format("Adress: {0}", CountOfKey));
            return output.ToString();
        }
    }
}

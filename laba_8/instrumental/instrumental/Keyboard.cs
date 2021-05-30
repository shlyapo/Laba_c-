using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace instrumental
{
    abstract class Keyboard : MusicInstrumental, IComparable<Keyboard>
    {
 
        public int CountOfKey { get; set; }




        public Keyboard(int count)
            : base()
        {
            CountOfKey = count;
        }
        public Keyboard(int count, int number)
            :base(number)
        {
            CountOfKey = count;
        }
        public Keyboard(int count, string high, string low, int cost, int age, string color, string country, int weight, float volume)
            : base(cost, age, color, country,high,low,weight, volume)
        {
            CountOfKey = count;
       
        }
        public abstract void ReplaceKey(int key);


        public abstract void PlayMusition(object source, InstrumentalListHandlerEventArgs instrumentalListHandlerEventArgs); 


        public override void Play()
        {
            Console.WriteLine("Инструмент играет");
        }
        public override string ToString()
        {
            return $"{base.ToString()} Кол - во клавиш: { CountOfKey}";
        }

        public int CompareTo([AllowNull] Keyboard other)
        {
            if (other == null)
                return 1;
            if (CountOfKey > other.CountOfKey)
                return 1;
            else if (CountOfKey < other.CountOfKey)
                return -1;
            else if (CountOfKey == other.CountOfKey && (Weight > other.Weight))
                return 1;
            else if (CountOfKey == other.CountOfKey && (Weight < other.Weight))
                return -1;
            return 0;
        }
    }
}

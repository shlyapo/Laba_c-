using System;
using System.Collections.Generic;
using System.Text;

namespace instrumental
{
    class GrandPiano:Keyboard, IMoved , IBurning
    {
        private string place;


        public float Sonority { get; set; }
        public int CountOfString { get; set; }
        public int CountOfBreakKey { get; set; }

        public string Place
        {
            get
            {
                return place;
            }
        }

        public uint Temperature { get; set; }

        public GrandPiano(float vol, float son, int stringg, int key, int count, string high, string low, int weight, uint temp)
            : base(count)
        {
            Sonority = son;
            CountOfString = stringg;
            CountOfBreakKey = key;
            Temperature = temp;
        }
        public GrandPiano(float vol, float son, int stringg, int key, int count, string high, string low, int weight, int number)
            : base(count, number)
        {

            Sonority = son;
            CountOfString = stringg;
            CountOfBreakKey = key;
        }
        public GrandPiano(float vol, float son, int stringg, int key, int count, string high, string low, int cost, int age, string color, string country, int weight)
            : base(count, high, low, cost, age, color, country, weight, vol)
        {
            Sonority = son;
            CountOfString = stringg;
            CountOfBreakKey = key;
        }
        public override void Play()
        {
            Console.WriteLine($"Рояль играет мелодию для Вас!!!!");
        }
        public override string ToString()
        {
            return $"{base.ToString()} Сонарность: {Sonority} Кол-во струн: {CountOfString} Кол-во сломанных клавиш {CountOfBreakKey}";
        }

        public override void ReplaceKey(int key)
        {
            if (CountOfBreakKey > 0)
            {
                CountOfBreakKey--;
                Console.WriteLine($"Заменяем клавишу рояля номер {key} на новую");
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public void MovedIntrumental(string place)
        {
            this.place = place;
            Console.WriteLine($"Рояль был передвинут - {place}");
        }

        public bool IsBurn(int temperature)
        {
            if (temperature > Temperature)
            {
                Console.WriteLine($"Рояль мирно горит в огне Минского театра музыки, все пожарные ехали на другие более важные задачи");
                return true;
            }
            else
                return false;
        }

        public override void PlayMusition(object source, InstrumentalListHandlerEventArgs instrumentalListHandlerEventArgs)
        {
            Console.WriteLine($"Рояль играет для вас мелодию {instrumentalListHandlerEventArgs.Sound}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace instrumental
{
    class Synthesizer : Keyboard, IMoved
    {
        private int power;
        private string place="";

        public ModeSynt ModeSynt { get; set; }

        public string Place
        {
            get
            {
                return place;
            }
        }

        public int Power {
            get
            {
                return power;
            }
            set
            {
                if (power < 0)
                    power = 0;
                else
                {
                    power = value;
                }
            }
        }

        public Synthesizer(int count, string high, string low, int cost, int age, string color, string country, int weight, int power, ModeSynt modeSynt, float volume) : base(count, high, low, cost, age, color, country, weight, volume)
        {
            this.power = power;
            ModeSynt = modeSynt;
        }

        public override void GetInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public override void Play()
        {
            Console.WriteLine($"Синтезатор играет мелодию для Вас!!!!");
        }

        public override void ReplaceKey(int key)
        {
            Console.WriteLine($"Заменяем клавишу синтезатора номер {key} на новую");
        }


        public override string ToString()
        {
            return $"{base.ToString()} Мощность: {power} Режим работы: {Enum.GetName(typeof(ModeSynt), ModeSynt)}";
        }

        public void MovedIntrumental(string place)
        {
            Console.WriteLine($"Синтезатор был передвинут - {place}");
        }

        public override void PlayMusition(object source, InstrumentalListHandlerEventArgs instrumentalListHandlerEventArgs)
        {
            Console.WriteLine($"Синтезатор играет для вас мелодию {instrumentalListHandlerEventArgs.Sound}");
        }
    }



    enum ModeSynt
    {
        Orch,
        GrandPiano,
        Organ,
        Piano
    }
}

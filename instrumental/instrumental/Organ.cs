using System;
using System.Collections.Generic;
using System.Text;

namespace instrumental
{
    class Organ:Keyboard, IBurning
    {
        public float Sonority { get; set; }
        public uint CountOfRow { get; set; }
        public uint CountOfColumn { get; set; }
        public int CountOfBreakKey { get; set; }
        public uint Temperature { get; set; }

        public Organ(float vol, float son, int stringg, int key, int count, string high, string low, int weight)
            : base(count)
        {
            Sonority = son;
            CountOfBreakKey = key;
        }
        public Organ(float vol, float son, int stringg, int key, int count, string high, string low, int weight, int number)
            : base(count, number)
        {

            Sonority = son;
            CountOfBreakKey = key;
        }
        public Organ(float vol, float son, int stringg, int key, int count, string high, string low, int cost, int age, string color, string country, int weight, uint countOfColumn, uint countOfRow)
            : base(count, high, low, cost, age, color, country, weight, vol)
        {
            Sonority = son;
            CountOfBreakKey = key;
            CountOfColumn = countOfColumn;
            CountOfRow = countOfRow;
        }
        public override void Play()
        {
            Console.WriteLine($"Орган играет мелодию для Вас!!!!");
        }
        public override string ToString()
        {
            return $"{base.ToString()} Сонарность: {Sonority} Кол-во рядов: {CountOfRow} Кол-во столбцов: {CountOfColumn} Кол-во сломанных клавиш {CountOfBreakKey}";
        }

        public override void ReplaceKey(int key)
        {
            if (CountOfBreakKey > 0)
            {
                CountOfBreakKey--;
                Console.WriteLine($"Заменяем клавишу органа номер {key} на новую");
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public bool IsBurn(int temperature)
        {
            if (temperature > Temperature)
            {
                Console.WriteLine($"Орган полыхает в огне, скорее потушите его");
                return true;
            }
            else
                return false;
        }

    }
}

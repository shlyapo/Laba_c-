using System;

namespace instrumental
{
    public abstract class MusicInstrumental
    {
        public string NameOfInstrumental { get; set; }
        public string Country { get; set; }
        public int Cost { get; set; }
        public int Age { get; set; }
        public string HighSound { get; set; }
        public string LowSound { get; set; }
        public virtual int Weight { get; set; }
        public float Volume { get; set; }
        public string Color { get; set; }
        public MusicInstrumental[] data;
        public MusicInstrumental()
        {
        }
        public MusicInstrumental(int number)
        {
            data = new MusicInstrumental[number];
        }
        public abstract void Play();

        public MusicInstrumental(int cost, int age, string color, string country, string highSound, string lowSound, int weight, float volume = 0)
        {
            Country = country;
            Cost = cost;
            Age = age;
            Color = color;
            HighSound = highSound;
            LowSound = lowSound;
            Weight = weight;
            Volume = volume;
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

        public abstract void  GetInfo();

        public override string ToString()
        {
            return $" Имя : {NameOfInstrumental} Страна: {Country} Возраст: {Age} Цвет: {Color} Вес: {Weight} Громкость: {Volume} Высокие частоты: {HighSound} Низкие частоты: {LowSound}";
        }
    }
}

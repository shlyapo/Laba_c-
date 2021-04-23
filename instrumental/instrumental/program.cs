using System;

namespace instrumental
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicInstrumental inst = new MusicInstrumental(1000, 15, "gray", "USA");
            inst[0] = new MusicInstrumental { NameOfInstrumental = "piano" };
                inst.GetInfo();
        }
    }
}
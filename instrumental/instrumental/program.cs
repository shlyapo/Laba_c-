using System;

namespace instrumental
{
    class Program
    {
        static void Main(string[] args)
        {
            Keyboard inst2 = new Organ(6000, 8, 45, 80, 65, "a", "b", 10000);
            Keyboard inst3 = new Synthesizer(34, "a", "b", 4500, 10, "black", "USA", 45, 2000, ModeSynt.Organ, 4000);
            Console.WriteLine(inst3.Color);
            inst3.Play();
            inst2.ReplaceKey(8);
            IBurning inst4 = new Organ(6000, 6789, 5787, 88, 345, "f", "e", 678);
            inst4.IsBurn(700);
            IMoved inst5 = new GrandPiano(5000, 9, 32, 33, 33, "c", "f", 5000, 90);
            inst5.MovedIntrumental("paradise");
        }
    }
}
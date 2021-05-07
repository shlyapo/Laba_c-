using System;
using System.Runtime.InteropServices;

namespace Library4_2
{
    class Program
    {
        public static double InputNumber()
        {
            bool run = true;
            double number_temp = 0;
            while (run)
            {
                run = false;
                Console.WriteLine("enter the number");
                string temp = Console.ReadLine();
                if (double.TryParse(temp, out number_temp))
                {
                    Console.WriteLine("number entered");
                }
                else
                {
                    Console.WriteLine("enter correct number");
                    run = true;
                }
            }
            return number_temp;
        }

        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double MillimetersToCentimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double MillimetersToDecimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double MillimetersToMeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double MillimetersToKilometers(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double CentimetersToMillimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double CentimetersToDecimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double CentimetersToMeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double CentimetersToKilometers(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double DecimetersToMillimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double DecimetersToCentimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double DecimetersToMeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double DecimetersToKilometers(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double MetersToMillimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double MetersToCentimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double MetersToDecimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double MetersToKilometers(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double KilometersToMillimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double KilometersToCentimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double KilometersToDecimeters(double number);
        [DllImport("../..Library4_2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double KilometersToMeters(double number);
       
        static void Main(string[] args)
        {
            double number = InputNumber();
            Console.WriteLine(MillimetersToCentimeters(number));
            Console.WriteLine(MetersToMillimeters(567));
            Console.WriteLine(KilometersToDecimeters(893));
            Console.WriteLine(DecimetersToMeters(43));
        }
    }
}

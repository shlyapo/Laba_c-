using System;

namespace laba_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong firstNumber, lastNumber, comp = 1;
            int count = 0, temp = 0;
            while (temp == 0)
            {
                Console.Write("Введите первое число интервала ");
                string numberFirst = Console.ReadLine();
                if (UInt64.TryParse(numberFirst, out firstNumber))
                {
                    Console.Write("Введите последнее число интервала ");
                    string numberLast = Console.ReadLine();
                    if (UInt64.TryParse(numberLast, out lastNumber)||lastNumber<firstNumber)
                    {
                        if (firstNumber == 0||lastNumber==0)
                        {
                            Console.WriteLine("Бесконечное количество двоек, т.к. произведение равно 0");
                        }
                        else
                        {
                            while (firstNumber <= lastNumber)
                            {
                                comp *= firstNumber;
                                firstNumber++;
                            }
                            while (comp % 2 == 0)
                            {
                                comp /= 2;
                                count++;
                            }
                            ulong twoInPow = Convert.ToUInt64(Math.Pow(2, count));
                            Console.Write($"Максимальная степень: {count}.  Двойка в этой степени: {twoInPow}");
                        }
                        temp++;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректный ввод");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректный ввод");
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}


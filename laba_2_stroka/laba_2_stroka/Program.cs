using System;

namespace laba_2_stroka
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b','c','d','e','f','g','h','i','j','k','l','m', 'n', 'o', 'p', 'q', 'r','s', 't', 'u', 'v','w','x', 'y', 'z'};
            Console.WriteLine("Введите строку");
            string oldLine=" ";
            int flag = 0;
            while (flag==0)
            {
                int count = 0;
                 oldLine = Console.ReadLine();
                for (int j = 0; j < oldLine.Length; j++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (oldLine[j] == alphabet[i])
                            count++;
                    }
                }
                if (count == oldLine.Length)
                    flag++;
                else
                {
                    Console.WriteLine("Вы ввели некорректный ввод. Введите строку:");
                    oldLine = " ";
                }
            }
            string line = "";
            line += oldLine[0];
            for (int i=1; i<oldLine.Length; i++)
            {
                if (oldLine[i-1] == 'a' || oldLine[i-1] == 'e' || oldLine[i-1] == 'i' || oldLine[i-1] == 'o' || oldLine[i-1] == 'u' || oldLine[i-1] == 'y')
                {
                    for (int j = 0; j < 26; j++)
                    {
                        if (oldLine[i] == alphabet[j])
                        {
                            if (j != 25)
                                line += alphabet[j + 1];
                            else
                                line += "a";
                        }
                    }
                }
                else
                    line += oldLine[i];
            }
            Console.WriteLine(line);
        }
    }
}
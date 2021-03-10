using System;
using System.IO;
using System.Text;

namespace lab_1_gallows
{
    class Program
    {
        static void ShowGallows(char[,] gallows)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 41; j++)
                {
                    Console.Write($"{gallows[i, j]}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string[] line = File.ReadAllLines(@"C:\\word_rus.txt", Encoding.Default);
            Console.WriteLine("Добрый день!!!");
            int play = 0;
            while (play == 0)
            {
                int mistake = 0, forWin = 2, move = 0;
                char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                char[,] gallows = new char[12, 41];
                Random rand = new Random();
                int numberOfWord = rand.Next(0, line.Length - 1);
                string word = line[numberOfWord];
                int numberOfLetters = word.Length;
                while (forWin != numberOfLetters)
                {
                    int count = 0;
                    if (move == 0)
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            for (int j = 0; j < 41; j++)
                            {
                                if (i == 0 || i == 11 || j == 0 || j == 40)
                                    gallows[i, j] = '*';
                                else if (i == 1 && j > 1 && j < 9)
                                    gallows[i, j] = '_';
                                else if ((i == 8 || i == 10) && (j > 4 && j < 4 + numberOfLetters + 1))
                                    gallows[i, j] = '-';
                                else if ((j == 2 && i > 1 && i < 10) || (i == 9 && (j == 4 || j == 4 + 1 + numberOfLetters)) || (j == 5 && (i == 2 || i == 3)))
                                    gallows[i, j] = '|';
                            }
                        }
                        gallows[9, 5] = word[0];
                        gallows[9, 4 + numberOfLetters] = word[numberOfLetters - 1];
                        int l = 0;
                        while (l != numberOfLetters - 2)
                        {
                            gallows[9, 6 + l] = '_';
                            l++;
                        }
                        ShowGallows(gallows);
                    }
                    else
                    {
                        string tempLetter = "";
                        int counter = 0;
                        while (counter == 0)
                        {
                            Console.Write("Введите букву:");
                            tempLetter = Console.ReadLine();
                            if (tempLetter.Length != 1)
                            {
                                Console.Write("Вы ввели некорректное значение.");
                                tempLetter = " ";
                            }
                            else
                                counter++;
                        }
                        char letter = Convert.ToChar(tempLetter);
                        for (int i = 0; i < 33; i++)
                        {
                            if (alphabet[i] == letter)
                                count++;
                        }
                        if (count == 0)
                        {
                            Console.Write("Вы уже вводили эту букву или этот символ не подходит.");
                            continue;
                        }
                        else
                        {
                            int tempNumber = 0;
                            for (int i = 1; i < numberOfLetters - 1; i++)
                            {
                                if (word[i] == letter)
                                    tempNumber++;

                            }
                            for (int j = 0; j < 33; j++)
                            {
                                if (alphabet[j] == letter)
                                    alphabet[j] = '*';
                            }
                            if (tempNumber == 0)
                            {
                                ++mistake;
                                switch (mistake)
                                {
                                    case 1:
                                        gallows[4, 5] = '0';
                                        break;
                                    case 2:
                                        gallows[5, 5] = gallows[6, 5] = '|';
                                        break;
                                    case 3:
                                        gallows[5, 4] = '-';
                                        break;
                                    case 4:
                                        gallows[5, 6] = '-';
                                        break;
                                    case 5:
                                        gallows[7, 4] = '/';
                                        break;
                                    case 6:
                                        gallows[7, 6] = '\\';
                                        break;
                                }
                            }
                            else
                            {
                                for (int j = 5, i = 0; i < numberOfLetters - 1; ++j, ++i)
                                {
                                    if (word[i] == letter)
                                    {
                                        gallows[9, j] = letter;
                                        forWin++;
                                    }
                                }
                            }
                            ShowGallows(gallows);
                        }
                    }
                    move++;
                    if (mistake == 6)
                        break;
                }
                if (forWin != numberOfLetters)
                {
                    Console.WriteLine("Вы проиграли :( Загаданное слово: ");
                    Console.WriteLine(word);
                }
                else
                    Console.WriteLine(" Вы выиграли!!!:)");
                int temp = 0;
                string answer = "";
                Console.WriteLine(" Хотите ещё поиграть? Да/нет ");
                while (temp == 0)
                {
                    answer = Console.ReadLine();
                    if (answer == "Да" || answer == "да" || answer == "нет" || answer == "Нет")
                    {
                        if (answer == "Нет" || answer == "нет")
                        {
                            Console.WriteLine("До свидания!!!");
                            play++;
                        }
                        else
                            play = 0;
                        temp++;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректный ответ ");
                        answer = " ";
                    }
                }
            }
        }
    }
}

       
       

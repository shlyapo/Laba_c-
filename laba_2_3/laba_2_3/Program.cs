using System;
//using System.Text;

namespace laba_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOne = 0, countTwo = 0, countThree = 0, countFour = 0, countFive = 0, countSix = 0, countZero = 0, countSeven = 0, countEight=0, countNine = 0;
            string date = Convert.ToString(DateTime.Now);
            for (int i = 0; i < date.Length; i++)
            {
                switch (date[i])
                {
                    case '0':
                        countZero++;
                        break;
                    case '1':
                        countOne++;
                        break;
                    case '2':
                        countTwo++;
                        break;
                    case '3':
                        countThree++;
                        break;
                    case '4':
                        countFour++;
                        break;
                    case '5':
                        countFive++;
                        break;
                    case '6':
                        countSix++;
                        break;
                    case '7':
                        countSeven++;
                        break;
                    case '8':
                        countEight++;
                        break;
                    case '9':
                        countNine++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Время сейчас:{date}, количество нулей:{countZero}, количество единиц:{countOne}, количество двоек:{countTwo}, количество троек:{countThree}, количество четвёрок:{countFour}, количество пятёрок:{countFive}, количество шестёрок:{countSix}, количество семёрок:{countSeven}, количество восьмёрок:{countEight}, количество девяток:{countNine}.");
           int countOneUtc = 0, countTwoUtc = 0, countThreeUtc = 0, countFourUtc = 0, countFiveUtc = 0, countSixUtc = 0, countZeroUtc = 0, countSevenUtc = 0, countEightUtc = 0, countNineUtc = 0;
            string dateUtc = Convert.ToString(DateTime.UtcNow);
            for (int i = 0; i < dateUtc.Length; i++)
            {
                switch (dateUtc[i])
                {
                    case '0':
                        countZeroUtc++;
                        break;
                    case '1':
                        countOneUtc++;
                        break;
                    case '2':
                        countTwoUtc++;
                        break;
                    case '3':
                        countThreeUtc++;
                        break;
                    case '4':
                        countFourUtc++;
                        break;
                    case '5':
                        countFiveUtc++;
                        break;
                    case '6':
                        countSixUtc++;
                        break;
                    case '7':
                        countSevenUtc++;
                        break;
                    case '8':
                        countEightUtc++;
                        break;
                    case '9':
                        countNineUtc++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Время сейчас по Гринвичу:{dateUtc}, количество нулей:{countZeroUtc}, количество единиц:{countOneUtc}, количество двоек:{countTwoUtc}, количество троек:{countThreeUtc}, количество четвёрок:{countFourUtc}, количество пятёрок:{countFiveUtc}, количество шестёрок:{countSixUtc}, количество семёрок:{countSevenUtc}, количество восьмёрок:{countEightUtc}, количество девяток:{countNineUtc}.");
        }
    }
}

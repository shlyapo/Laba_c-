using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Numbers
{
    class Number : IFormattable
    {
        public long N { get; set; }

        private long m = 1;

        public long M { get
            {
                return m;
            }
            set
            {
                if (value > 0)
                {
                    m = value;
                }
            }
        }


        private long GCD(long a, long b)
        {
            if (a == b)
            {
                return a;
            }
            if (a > b)
            {
                long tmp = a;
                a = b;
                b = tmp;
            }
            return GCD(a, b - a);
        }

        private void Cut()
        {
            var gcd = GCD(Math.Abs(this.N), Math.Abs(this.M));
            this.M = this.M / gcd;
            this.N = this.N / gcd;
        }


        static public Number operator +(Number a, Number b)
        {
            Number sum = new Number() { N = (a.M * b.N + a.N * b.M), M = (a.M * b.M) };
            sum.Cut();
            return sum;
        }

        static public Number operator-(Number a, Number b){
            Number sum = new Number() { N = (a.N * b.M - a.M * b.N), M = (a.M * b.M) };
            sum.Cut();
            return sum;
        }

        static public Number operator*(Number a, Number b)
        {
            Number sum = new Number() { N = (a.N * b.N), M = (a.M * b.M) };
            sum.Cut();
            return sum;
        }

        static public Number operator/(Number a, Number b)
        {
            Number sum = new Number() { N = (a.N * b.M), M = (a.M * b.N) };
            sum.Cut();
            return sum;
        }


        static public bool operator!=(Number a, Number b)
        {
            return !(a == b);
        }



        public override string ToString()
        {
            return $"{N}/{M}";
        }

        public override bool Equals(object obj)
        {
            return obj is Number number &&
                   N == number.N &&
                   M == number.M;
        }

        public override int GetHashCode()
        {
            int hashCode = -1728598895;
            hashCode = hashCode * -1521134295 + N.GetHashCode();
            hashCode = hashCode * -1521134295 + M.GetHashCode();
            return hashCode;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if(format == null)
            {
                return this.ToString();
            }

            if(format == "D")
            {
                return $"{N / M}";
            }

            if(format == "C")
            {
                return $"Числитель - {N}, знаминатель - {M}";
            }

            throw new ArgumentException("Неверный формат");
        }




        static public bool operator>(Number a, Number b)
        {
            if (a == b)
            {
                return false;
            }

            var res = a - b;
            if (res.N > 0)
            {
                return true;
            }
            else return false;
        }

        static public bool operator<(Number a, Number b)
        {
            if (a == b)
                return false;
            return !(a > b);
        }


        public void ParseToNumber(string input, out Number number)
        {
            if(input is null)
            {
                throw new ArgumentNullException("Пустая строка");
            }
            Regex pattern1 = new Regex(@"^(-?\d+)/(\d+)$");
            Regex pattern2 = new Regex(@"^(-?d+)$");
            Regex pattern3 = new Regex(@"^(-?\d+)\((\d+)/(\d+)\)$");

            if (pattern1.IsMatch(input))
            {
                Match match = pattern1.Match(input);
                number = new Number() { N = long.Parse(match.Groups[1].Value), M = long.Parse( match.Groups[2].Value) };
                return;
            }
            if (pattern2.IsMatch(input))
            {
                Match match = pattern2.Match(input);
                number = new Number() { N = long.Parse(match.Groups[1].Value) , M = 1};
                return;
            }
            if (pattern3.IsMatch(input))
            {
                Match match = pattern3.Match(input);
                long integer = long.Parse(match.Groups[1].Value);
                int sign = integer > 0 ? 1 : -1;
                long div = long.Parse(match.Groups[3].Value);
                number = new Number() { N = (Math.Abs(integer) * div + long.Parse(match.Groups[2].Value)) * sign, M = div };
                return;
            }

            //number = new Number();
            throw new ArgumentException("Верный формат строки");

        }


        static public bool operator==(Number a, Number b)
        {

            if(a==null || b == null)
            {
                return false;
            }
            a.Cut();
            b.Cut();
            if(a.M == b.M && a.N == b.N)
            {
                return true;
            }
            return false;
        }


    }

}

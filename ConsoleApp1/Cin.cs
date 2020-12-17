using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    public static class Cin
    {
        private static char _nextChar = '\0';

        public static string Next(string type = "string")
        {
            StringBuilder stringBuilder = new StringBuilder();
            while (true)
            {
                char ch;
                if (_nextChar != '\0')
                {
                    ch = _nextChar;
                    _nextChar = '\0';
                }
                else
                {
                    ch = Convert.ToChar(Console.Read());
                }

                if (Char.IsControl(ch) || Char.IsWhiteSpace(ch))
                {
                    if (stringBuilder.Length != 0)
                    {
                        _nextChar = ch;
                        break;
                    }
                }
                else if (type == "char")
                {
                    if (stringBuilder.Length != 0)
                    {
                        _nextChar = ch;
                        break;
                    }

                    stringBuilder.Append(ch);
                }
                else if (type == "int" || type == "long" || type == "bigInt" || type == "double")
                {
                    if (ch == '-' && stringBuilder.Length == 0 ||
                        Char.IsDigit(ch) ||
                        type == "double" && ch == '.' && stringBuilder.ToString().Count(f => f == '.') == 0)
                    {
                        stringBuilder.Append(ch);
                    }
                    else
                    {
                        _nextChar = ch;
                        break;
                    }
                }
                else
                {
                    stringBuilder.Append(ch);
                }
            }

            return stringBuilder.ToString();
        }

        public static int NextInt() => Convert.ToInt32(Next("int"));
        public static long NextLong() => Convert.ToInt64(Next("long"));
        public static double NextDouble() => Convert.ToDouble(Next("double"));
        public static char NextChar() => Convert.ToChar(Next("char"));
        public static string NextLine() => Console.ReadLine();
        public static BigInteger NextBigInteger() => BigInteger.Parse(Next("bigInt"));
    }
}
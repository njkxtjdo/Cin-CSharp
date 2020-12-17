using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    public class Cin : ICin
    {
        private char _nextChar = '\0';

        public string Next(string type = "String")
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
                else if (type == "Char")
                {
                    if (stringBuilder.Length != 0)
                    {
                        _nextChar = ch;
                        break;
                    }

                    stringBuilder.Append(ch);
                }
                else if (type == "Int32" || type == "Int64" || type == "BigInt" || type == "Double")
                {
                    if (ch == '-' && stringBuilder.Length == 0 ||
                        Char.IsDigit(ch) ||
                        type == "Double" && ch == '.' && stringBuilder.ToString().Count(f => f == '.') == 0)
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

        public int NextInt() => Convert.ToInt32(Next("Int32"));
        public long NextLong() => Convert.ToInt64(Next("Int64"));
        public double NextDouble() => Convert.ToDouble(Next("double"));
        public char NextChar() => Convert.ToChar(Next("Char"));
        public string NextLine() => Console.ReadLine();
        public BigInteger NextBigInteger() => BigInteger.Parse(Next("BigInt"));
    }
}
using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    public class Cin : ICin
    {
        private char _nextChar = '\0';

        public string Next(Type type = Type.String)
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
                else if (type == Type.Char)
                {
                    if (stringBuilder.Length != 0)
                    {
                        _nextChar = ch;
                        break;
                    }

                    stringBuilder.Append(ch);
                }
                else if (type == Type.Int32 || type == Type.Int64 || type == Type.BigInt || type == Type.Double)
                {
                    if (ch == '-' && stringBuilder.Length == 0 ||
                        Char.IsDigit(ch) ||
                        type == Type.Double && ch == '.' && stringBuilder.ToString().Count(f => f == '.') == 0)
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

        public int NextInt() => Convert.ToInt32(Next(Type.Int32));
        public long NextLong() => Convert.ToInt64(Next(Type.Int64));
        public double NextDouble() => Convert.ToDouble(Next(Type.Double));
        public char NextChar() => Convert.ToChar(Next(Type.Char));
        public string NextLine() => Console.ReadLine();
        public BigInteger NextBigInteger() => BigInteger.Parse(Next(Type.BigInt));
    }
}
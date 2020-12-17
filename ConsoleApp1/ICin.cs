using System.Numerics;

namespace ConsoleApp1
{
    public interface ICin
    {
        public string Next(string type = "string");
        public int NextInt();
        public long NextLong();
        public double NextDouble();
        public char NextChar();
        public string NextLine();
        public BigInteger NextBigInteger();
    }
}
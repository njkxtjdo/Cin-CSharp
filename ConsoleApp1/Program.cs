using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // ваш код от сюда
            ICin cin = new Cin();
            string a = cin.Next();
            int b = cin.NextInt();
            Console.WriteLine(a + b);
            // до сюда
        }
    }
}
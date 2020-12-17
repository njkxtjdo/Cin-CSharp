using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // ваш код от сюда
            ICin cin = new Cin();
            String a = cin.Next();
            Int32 b = cin.NextInt();
            Console.WriteLine(a + b);
            // до сюда
        }
    }
}
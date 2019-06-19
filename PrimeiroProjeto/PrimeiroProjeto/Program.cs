using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte x = 100;
            Byte n1 = 126;
            int n2 = 1000, n3 = 2147483647;
            long n4 = 2147483648L;

            Console.WriteLine("Hello World!");
            Console.WriteLine(x);
            n1++;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}

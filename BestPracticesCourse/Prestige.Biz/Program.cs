using System;

namespace Prestige.Biz
{
    class Program
    {
        public const int ConstantNumber = 100;
        public static readonly int ReadOnlyNumber = 0;

        static Program()
        {
            ReadOnlyNumber = 5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConstantNumber);
            Console.WriteLine(ReadOnlyNumber);
            Console.ReadKey();
        }
    }
}

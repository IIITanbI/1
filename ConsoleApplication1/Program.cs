using System;

namespace ConsoleApplication1
{
    public class A
    {
        public int GG { get; set; } = 5;
    }
    class Program
    {
        public static int GG { get; set; } = 5;
        static void Main(string[] args)
        {
            Console.WriteLine(GG);
            Console.Read();
        }
    }
}

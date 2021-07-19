using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Hello ");

            if (args.Length > 0 && string.Equals(args[0], "1"))
            {
                Console.WriteLine(new Supplier1());
            }
            else
            {
                Console.WriteLine(new Supplier2());
            }

            Console.Read();
        }
    }
}
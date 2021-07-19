using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var name = string.Empty;
            if (args.Length > 0 && string.Equals(args[0], "1"))
            {
                name = (new Supplier1()).getName();
            }
            else
            {
                name = (new Supplier2()).getName();
            }


            Console.Write($"Hello ${name}");

            Console.Read();
        }
    }
}
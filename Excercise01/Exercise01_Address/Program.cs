using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Josef Novák\nJindřišská 16\n111 50, Praha 1\n");

            Console.WriteLine();

            Console.WriteLine("Josef Novák");
            Console.WriteLine("Jindřišská 16");
            Console.WriteLine("111 50, Praha 1");

            Console.WriteLine();

            string[] @for = { "Josef Novák", "Jindřišská 16", "111 50, Praha 1" };
            for(int i = 0; i < @for.Length; i++)
            {
                Console.WriteLine(@for[i]);
            }
        }
    }
}

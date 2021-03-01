using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 65; i <= 90; i++)
            {
                Console.WriteLine((char)i);
            }

            int charDec = 65;
            while(charDec <= 90)
            {
                Console.WriteLine((char)charDec++);
            }

            charDec = 65;
            do
            {
                Console.WriteLine((char)charDec++);
            } while (charDec <= 90);

            Console.ReadKey();
        }
    }
}

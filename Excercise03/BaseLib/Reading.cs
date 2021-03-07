using System;

namespace Fei
{
    namespace BaseLib
    {
        public class Reading
        {
            public static int ReadInt(string message)
            {
                Console.Write(message + ": ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int result))
                    throw new ArgumentException("Input is not int.");

                return result;
            }

            public static double ReadDouble(string message)
            {
                Console.Write(message + ": ");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out double result))
                    throw new ArgumentException("Input is not double.");

                return result;
            }

            public static string ReadString(string message)
            {
                Console.Write(message + ": ");
                string input = Console.ReadLine();
                if (input.Length == 0)
                    throw new ArgumentException("String is empty.");

                return input;
            }

            public static char ReadChar(string message)
            {
                Console.Write(message + ": ");
                string input = Console.ReadLine();
                if (!char.TryParse(input, out char result))
                    throw new ArgumentException("Input is not char.");

                return result;
            }
        }
    }
}
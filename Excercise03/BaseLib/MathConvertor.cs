using System;
using System.Collections.Generic;
using System.Text;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Number system convertor
        /// </summary>
        class MathConvertor
        {
            /// <summary>
            /// Convert integer to binary
            /// </summary>
            /// <param name="input">integer number</param>
            /// <returns>binary form of input number</returns>
            public static string IntToBin(int input)
            {
                return Convert.ToString(input, 2);
            }

            /// <summary>
            /// Convert binary string to integer
            /// </summary>
            /// <param name="input">string with binary number</param>
            /// <returns>integer form of binary input</returns>
            public static int BinToInt(string input)
            {
                return Convert.ToInt32(input, 2);
            }

            private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            /// <summary>
            /// Convert roman string to integer
            /// </summary>
            /// <param name="roman">input string with roman format number</param>
            /// <returns>integer form of roman input</returns>
            public static int RomanToInt(string roman)
            {
                int number = 0;
                for (int i = 0; i < roman.Length; i++)
                {
                    if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
                    {
                        number -= RomanMap[roman[i]];
                    }
                    else
                    {
                        number += RomanMap[roman[i]];
                    }
                }
                return number;
            }

            /// <summary>
            /// Convert integer to roman format string
            /// </summary>
            /// <param name="number">input integer</param>
            /// <returns>roman string form of integer input</returns>
            public static string IntToRoman(int number)
            {
                if (number <= 0 || number > 4000)
                {
                    throw new ArgumentOutOfRangeException(nameof(number));
                }

                int[] decimalValue = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                string[] romanNumeral = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
                int copy = number;
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < decimalValue.Length; i++)
                {
                    while (decimalValue[i] <= copy)
                    {
                        sb.Append(romanNumeral[i]);
                        copy -= decimalValue[i];
                    }
                }

                return sb.ToString();
            }
        }
    }
}


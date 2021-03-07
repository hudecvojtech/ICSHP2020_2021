using System;
using System.Collections.Generic;
using System.Text;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Library for mathematic operations
        /// </summary>
        class ExtraMath
        {
            /// <summary>
            /// Method for quadratic equation calculation
            /// </summary>
            /// <param name="a">x^2</param>
            /// <param name="b">x</param>
            /// <param name="c">const</param>
            /// <param name="x1">first root output</param>
            /// <param name="x2">second root output</param>
            /// <returns>true if it is possible to calculate</returns>
            public static bool QuadraticEquation(int a, int b, int c, out double x1, out double x2)
            {
                var preRoot = b * b - 4 * a * c;
                if (preRoot < 0)
                {
                    x1 = x2 = Double.NaN;
                    return false;
                } else if(preRoot == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    return true;
                } else
                {
                    x1 = (-b + Math.Sqrt(preRoot)) / (2 * a);
                    x2 = (-b - Math.Sqrt(preRoot)) / (2 * a);
                    return true;
                }
            }

            /// <summary>
            /// Method generates random double in range from min to max
            /// </summary>
            /// <param name="random">Instance of Random</param>
            /// <param name="min">min value</param>
            /// <param name="max">max value</param>
            /// <returns>Random double</returns>
            public static double RandomNumber(Random random, int min, int max) {
                return random.NextDouble() * (max - min) + min;
            }

        }
    }
}


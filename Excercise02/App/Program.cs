using Fei.BaseLib;
using System;

namespace App
{
    class Program
    {
        static private void PrintMenu()
        {
            Console.WriteLine(
                "1. Add element\n" +
                "2. Show array\n" +
                "3. Sort ASC\n" +
                "4. Sort DESC\n" +
                "5. Find min\n" +
                "6. Find first index of value\n" +
                "7. Find last index of value\n" +
                "8. Print menu\n" +
                "9. Exit\n"
            );
        }

        static void Main(string[] args)
        {
            int[] array = new int[0];
            int position = 0;
            PrintMenu();
            while (true)
            {
                try
                {
                    int selected = Reading.ReadInt("Menu item");
                    switch (selected)
                    {
                        case 1:
                            AddElement(ref array, ref position);
                            break;
                        case 2:
                            ShowArray(array);
                            break;
                        case 3:
                            SortAsc(array);
                            break;
                        case 4:
                            SortDesc(array);
                            break;
                        case 5:
                            FindMin(array);
                            break;
                        case 6:
                            FindFirst(array);
                            break;
                        case 7:
                            FindLast(array);
                            break;
                        case 8:
                            PrintMenu();
                            break;
                        case 9:
                            return;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private static void FindLast(int[] array)
        {
            int find = Reading.ReadInt("Value");
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] == find)
                {
                    Console.WriteLine("Found at position " + (i + 1));
                    return;
                }

            }

            Console.WriteLine("Value is not in array");
        }

        private static void FindFirst(int[] array)
        {
            int find = Reading.ReadInt("Value");
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == find)
                {
                    Console.WriteLine("Found at position " + (i + 1));
                    return;
                }
                   
            }

            Console.WriteLine("Value is not in array");
        }

        private static void FindMin(int[] array)
        {
            int min = int.MaxValue;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }

            Console.WriteLine(min);
        }

        private static void SortDesc(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        private static void SortAsc(int[] array)
        {
            Array.Sort(array);
        }

        private static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                Console.Write(array[i] + ", ");
            Console.WriteLine(array[array.Length - 1]);
        }

        private static void AddElement(ref int[] array, ref int position)
        {
            int input = Reading.ReadInt("Value");
            if (array.Length == position)
            {
                var temp = new int[array.Length + 1];
                for (var i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];
                }

                array = temp;
            }

            array[position++] = input;
        }
    }
}

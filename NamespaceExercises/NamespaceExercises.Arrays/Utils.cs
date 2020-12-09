using System;
using NumberUtils = NamespaceExercises.Numbers;

namespace NamespaceExercises.Arrays
{
    public static class Utils
    {
        public static int[] ReadArray(int length)
        {
            if (length < 0)
            {
                Console.WriteLine($"You have specified a negative length for the array ({length}), we will assume you mean an empty array!");
                return new int[0];
            }

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                int element = NumberUtils::Utils.ReadNumber($"Please enter element[{i}]=");

                array[i] = element;
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            if (array is null)
            {
                Console.WriteLine("Array argument is null!");
                return;
            }

            Console.WriteLine();
            Console.Write("Array: [");
            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                Console.Write($"{element}");

                if (i < array.Length - 1)
                {
                    Console.Write($",");
                }
            }

            Console.Write("]");
        }

        public static void PrintReversedArray(int[] array)
        {
            if (array is null)
            {
                Console.WriteLine("Array argument is null!");
                return;
            }

            Console.WriteLine();
            Console.Write("Reversed Array: [");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int element = array[i];
                Console.Write($"{element}");

                if (i > 0)
                {
                    Console.Write($",");
                }
            }

            Console.Write("]");
        }
    }
}

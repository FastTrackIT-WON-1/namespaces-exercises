using NumberUtils = NamespaceExercises.Numbers.Utils;
using ArraysUtils = NamespaceExercises.Arrays.Utils;

using System;
using Suff;

namespace NamespaceExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NumberUtils.ReadNumber("Please enter the array length=");
            int[] array = ArraysUtils.ReadArray(n);
            OtherStuff.Do();
            Console.WriteLine(n);
        }
    }
}

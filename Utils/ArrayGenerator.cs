using System;

namespace Sorts.Utils
{
    public static class ArrayGenerator
    {
        private static readonly Random Random = new Random();

        public static int[] Generate()
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = Random.Next(0, 15);

            return arr;
        }
    }
}
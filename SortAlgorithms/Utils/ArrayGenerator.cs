using System;

namespace SortingAlgorithms.Utils
{
    // TODO: move to a separate library after refactoring
    public static class ArrayGenerator
    {
        private static readonly Random Random = new Random();

        public static int[] Generate()
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = Random.Next(1, 10);

            return arr;
        }
    }
}
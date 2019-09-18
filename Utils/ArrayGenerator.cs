using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts.Utils
{
    public static class ArrayGenerator
    {
        public static int[] Generate()
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = random.Next(0, 15);
            return arr;
        }
    }
}

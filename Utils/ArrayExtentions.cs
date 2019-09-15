using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts.Utils
{
    public static class ArrayExtentions
    {
        public static string ToText(this int[] arr)
        {
            string arrString = string.Empty;
            for (int i = 0; i < arr.Length; i++)
                arrString += arr[i].ToString() + "   ";
            return arrString;
        }

        public static string GetIterationResult(int i, int[] arr)
        {
            string result = String.Format("Итерация №{0} ------- {1} \r\n", i, arr.ToText());
            return result;
        }
    }
}

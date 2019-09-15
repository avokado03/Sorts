using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorts.Utils;

namespace Sorts.Sort
{
    public class BubbleSort: ISort
    {
        public void Sort (int[] arr, System.Windows.Forms.TextBox target)
        {
            for (int i=0; i<arr.Length; i++)
            {
                //j<arr.Length-i; - т.к. самый большой элемент уже "всплыл", его не проверяем
                for (int j=1; j<arr.Length-i; j++)
                {
                    if (arr[j]<arr[j-1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = t;
                    }
                }
                target.Text += ArrayExtentions.GetIterationResult(i, arr);
            }
        }
    }
}

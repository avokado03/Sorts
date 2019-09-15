using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorts.Utils;

namespace Sorts.Sort
{
    public class InsertionSort : ISort
    {
        public void Sort(int[] arr, TextBox target)
        {
            for (int i =1; i<arr.Length; i++)
            {
                int j = i - 1;
                while (j>=0 && arr[j] > arr[j+1])
                {
                    //да, мне лень это в функцию вынести...
                    int t = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = t;
                    j--;
                }
                target.Text += ArrayExtentions.GetIterationResult(i, arr);
            }
        }
    }
}

using Sorts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorts.Sort
{
    public class CountingSort : ISort
    {
        public void Sort(int[] arr, TextBox target)
        {
            target.Text += string.Format("\r\n Array: {0}", arr.ToText());
            int max = arr.Max();
            int min = arr.Min();
            int[] count = new int[max+1];
            count.DefaultIfEmpty(0);

            int[] sorted = new int[arr.Length];
            sorted.DefaultIfEmpty(0);

            for(int i = 0; i<arr.Length; i++)
            {
                count[arr[i]]++;
            }
            target.Text += string.Format("\r\n CountArray: {0}", count.ToText());

            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i] + count[i - 1];
            }
            target.Text += string.Format("\r\n RecountArray: {0}", count.ToText());

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int value = arr[i];
                int position = count[value] - 1;
                sorted[position] = value;
                count[value]--;
                target.Text += string.Format("\r\n Array: {0}", sorted.ToText());
            }
        }
    }
}

using System.Linq;
using System.Text;
using SortingAlgorithms.Interfaces;
using SortingAlgorithms.Utils;

namespace SortingAlgorithms.Sorts
{
    public class CountingSort : ISorter
    {
        public string Sort(int[] arr)
        {
            var sb = new StringBuilder();

            sb.Append(string.Format("\r\n Array: {0}", arr.ToText()));

            int max = arr.Max();
            int min = arr.Min();
            int[] count = new int[max + 1];

            int[] sorted = new int[arr.Length];

            foreach (var t in arr)
            {
                count[t]++;
            }

            sb.Append(string.Format("\r\n CountArray: {0}", count.ToText()));

            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i] + count[i - 1];
            }

            sb.Append(string.Format("\r\n RecountArray: {0}", count.ToText()));

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int value = arr[i];
                int position = count[value] - 1;
                sorted[position] = value;
                count[value]--;
                sb.Append(string.Format("\r\n Array: {0}", sorted.ToText()));
            }

            return sb.ToString();
        }
    }
}
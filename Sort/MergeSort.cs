using System.Linq;
using System.Text;
using Sorts.Utils;

namespace Sorts.Sort
{
    public class MergeSort : ISorter
    {
        public string Sort(int[] arr)
        {
            var sb = new StringBuilder();

            sb.Append(MergeSorting(arr).ToText());

            return sb.ToString();
        }

        private int[] MergeSorting(int[] arr)
        {
            int mid = arr.Length / 2;
            if (mid <= 1)
                return arr;
            int[] left = arr.Take(mid).ToArray();
            int[] right = arr.Skip(mid).ToArray();
            left = MergeSorting(left);
            right = MergeSorting(right);
            var r = Merge(left, right);
            return r;
        }

        private int[] Merge(int[] left, int[] right)
        {
            int i = 0, j = 0;
            int leftLength = left.Length;
            int rightLength = right.Length;
            int[] result = new int[leftLength + rightLength];
            int index = 0;
            while (i < leftLength && j < rightLength)
            {
                if (i < leftLength && left[i] < right[j])
                {
                    result[index] = left[i];
                    i++;
                }
                else
                {
                    result[index] = right[j];
                    j++;
                }

                index++;
            }

            return result;
        }
    }
}
using System.Linq;
using System.Text;
using SortingAlgorithms.Interfaces;
using SortingAlgorithms.Utils;

namespace SortingAlgorithms.Sorts
{
    public class MergeSort : ISorter
    {
        private  StringBuilder Builder;

        public MergeSort()
        {
            Builder = new StringBuilder();
        }

        public string Sort(int[] arr)
        {
            MergeSorting(arr);
            return Builder.ToString();
        }

        private void MergeSorting(int[] arr)
        {
            int n = arr.Length;
            if (n < 2)
                return;
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for (int i = 0; i < mid; i++)
                left[i] = arr[i];

            for (int i = mid; i < n; i++)
                right[n - i - 1] = arr[i];

            MergeSorting(left);
            MergeSorting(right);
            Merge(left, right, arr);
            Builder.Append(arr.ToText() + "\r\n ");
        }
        private static void Merge(int[] left, int[] right, int[] A)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    A[k] = left[i];
                    i++;
                }
                else
                {
                    A[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < left.Length)
            {
                A[k] = left[i];
                i++;
                k++;
            }
            while (j < right.Length)
            {
                A[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
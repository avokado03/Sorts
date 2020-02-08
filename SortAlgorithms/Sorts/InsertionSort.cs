using System.Text;
using SortingAlgorithms.Interfaces;
using SortingAlgorithms.Utils;

namespace SortingAlgorithms.Sorts
{
    public class InsertionSort : ISorter
    {
        public string Sort(int[] arr)
        {
            var stringBuilder = new StringBuilder();

            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && arr[j] > arr[j + 1])
                {
                    //да, мне лень это в функцию вынести...
                    int t = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = t;
                    j--;
                }

                stringBuilder.Append(arr.GetIterationResult(i));
            }

            return stringBuilder.ToString();
        }
    }
}
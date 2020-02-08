using System.Text;
using SortingAlgorithms.Interfaces;
using SortingAlgorithms.Utils;


namespace SortingAlgorithms.Sorts
{
    public class BubbleSort : ISorter
    {
        public string Sort(int[] arr)
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                //j<arr.Length-i; - т.к. самый большой элемент уже "всплыл", его не проверяем
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j] >= arr[j - 1])
                        continue;

                    var t = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = t;
                }

                stringBuilder.Append(arr.GetIterationResult(i));
            }

            return stringBuilder.ToString();
        }
    }
}
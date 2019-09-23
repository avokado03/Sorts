using System.Text;

namespace Sorts.Utils
{
    public static class ArrayExtensions
    {
        public static string ToText(this int[] input)
        {
            var result = new StringBuilder();

            foreach (var t in input)
                result.Append(t + "   ");

            return result.ToString();
        }

        public static string GetIterationResult(this int[] arr, int i)
        {
            var result = string.Format("Итерация №{0} ------- {1} \r\n", i, arr.ToText());
            return result;
        }
    }
}

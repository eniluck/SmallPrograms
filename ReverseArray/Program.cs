using System;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 28923471287;
            App app = new App();
            var result = app.ConvertNumberToReversedArray(number);
            Console.WriteLine($"{number} = [{string.Join(",", result)}]");
            Console.ReadLine();
        }
    }

    public class App
    {
        public long[] ConvertNumberToReversedArray(long number)
        {
            //в массив цифр
            string numbers = number.ToString();
            char[] chars = numbers.ToCharArray();
            long[] longs = chars.Select(c => Convert.ToInt64(c.ToString())).ToArray();

            //сортируем и переворачиваем
            Array.Reverse(longs);

            return longs;
        }
    }
}

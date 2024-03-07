using System;

namespace Week3
{
    public class ArrayStatistics
    {
        private int[] numbers;

        public ArrayStatistics(int[] numbers)
        {
            this.numbers = numbers ?? Array.Empty<int>();
        }

        public int Total()
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }
    }
}
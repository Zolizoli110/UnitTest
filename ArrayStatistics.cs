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

        public bool Contains(int num)
        {
            foreach (int n in numbers)
            {
                if (n == num)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Sorted()
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (!(numbers[i] >= numbers[i - 1]))
                {
                    return false;
                }
            }

            return true;
        }

        public int FirstGreater(int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (value < numbers[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
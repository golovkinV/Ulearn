using System;

namespace Ex4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("n = ");
            string a = Console.ReadLine();

            if (Int32.TryParse(a, out int n))
            {
                int[] numbers = new int[n];
                int maxSum = -2147483648;
                int index = -1;

                Random random = new Random();
                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] = random.Next(-100, 100);

                foreach (int el in numbers)
                    Console.Write(el + " ");

                Console.Write("\nm = ");
                string b = Console.ReadLine();

                if (Int32.TryParse(b, out int m))
                {
                    if (n != m)
                    {
                        for (int i = 0; i < numbers.Length - m; i++)
                        {
                            int sum = 0;
                            for (int j = i; j < i + m; j++)
                                sum += numbers[j];

                            if (sum > maxSum)
                            {
                                maxSum = sum;
                                index = i;
                            }
                        }

                        for (int i = index; i < index + m; i++)
                            Console.Write(numbers[i] + " ");
                        Console.Write("\nmaxSum = " + maxSum);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}


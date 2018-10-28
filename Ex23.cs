using System;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            string a = Console.ReadLine();
            double x = double.Parse(a);

            double[] numbers = new double [51];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;

            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;

            while (firstIndex != lastIndex)
            {
                double sum = numbers[firstIndex] + numbers[lastIndex];
                if (sum < x)
                    firstIndex++;
                else if (sum > x)
                    lastIndex--;
                else
                {
                    Console.Write("\n"+numbers[firstIndex] + "+" + numbers[lastIndex]);
                    break;
                }
            }
            if (firstIndex == lastIndex) Console.Write("\nЭлементы не найдены");
            Console.ReadLine();
        }
    }
}

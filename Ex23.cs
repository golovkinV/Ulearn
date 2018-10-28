using System;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            string a = Console.ReadLine();
            int x = int.Parse(a);

            int[] numbers = CreateArray();
            PrintElements(numbers,x);

            Console.ReadLine();
        }

        static int[] CreateArray()
        {
            int[] array = new int[51];
            for (int i = 0; i < array.Length; i++)
                array[i] = i;
            return array;
        }

        static void PrintElements(int[] numbers, int x)
        {
            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;

            while (firstIndex != lastIndex)
            {
                int sum = numbers[firstIndex] + numbers[lastIndex];
                if (sum < x)
                    firstIndex++;
                else if (sum > x)
                    lastIndex--;
                else
                {
                    Console.Write("{0} + {1}", numbers[firstIndex], numbers[lastIndex]);
                    break;
                }
            }
            if (firstIndex == lastIndex)
                Console.Write("Элементы не найдены");
        }
    }
}

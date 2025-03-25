using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateRandomArray(9, 0, 10);           
            (int countEven, int countOdd) = CountEvenOdd(numbers);

            Console.WriteLine($"Четных элементов: {countEven}");
            Console.WriteLine($"Нечетных элементов: {countOdd}");           
            if (countEven > countOdd)
                Console.WriteLine("Больше четных элементов.");
            else if (countOdd > countEven)
                Console.WriteLine("Больше нечетных элементов.");
            else
                Console.WriteLine("Четных и нечетных элементов поровну.");

            Console.ReadKey();
        }       
        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }
            return array;
        }      
        static (int, int) CountEvenOdd(int[] array)
        {
            int even = 0, odd = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                    even++;
                else
                    odd++;
            }
            return (even, odd);
        }     
        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
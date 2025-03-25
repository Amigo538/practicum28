using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i = 0, x = 0, y = 0;
            int[] mas = new int[14];
            for (i = 0; i < 14; i++)
                mas[i] = Input(mas, x, i);
            x = Mas(mas, x, i);
            Print(x);
            Console.Read();
        }
        static int Input(int[] mas, byte x, byte i)
        {
            Console.Write($"mas[{i}]= \t");
            mas[i] = int.Parse(Console.ReadLine());
            return mas[i];
        }
        static byte Mas(int[] mas, byte x, byte i)
        {
            for (i = 0; i < 14; i++)
            {
                if ((mas[i] % 2) == 0)
                {
                    x++;
                }
            }
            return x;
        }
        static void Print(byte x)
        {
            Console.WriteLine($"Всего четных: {x}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int nullVal = 0;
            int maxVal = Int32.MinValue;
            const int x = 5, y = 5;
            int n = x * y;
            int[] mas1 = new int[n];
            int[,] mas = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mas[i, j] = r.Next(0, 100);
                    Console.Write(mas[i, j] + " ");
                    if (mas[i, j] == 0)
                    {
                        nullVal++;
                    }

                }
                Console.WriteLine();
            }
            int z = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mas1[z] = mas[i, j];
                    z++;
                }
            }
            Array.Sort(mas1);
            int b = mas1[n - 1] + 1;
            int[] SortMas = new int[b];
            for (int i = 0; i < n; i++)
            {
                int c = mas1[i];
                SortMas[c]++;
            }
            for (int i = 0; i < b; i++)
            {
                if (SortMas[i] >= 2)
                {
                    maxVal = i;
                }
            }
            Console.WriteLine("Максимальное значение повторяющееся более одного раза: {0}", maxVal);
            Console.WriteLine("Количество строк без нулевых элементов: {0}", x - nullVal);
            Console.ReadKey();
        }
    }
}

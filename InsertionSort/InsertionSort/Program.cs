using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 22,27,16,2,18,6 };
            InsertionSort(ints);
            foreach (int i in ints)
            {
                Console.Write(i+", ");
            }
        }

        static int[] InsertionSort(int[] items)
        {
            int n = items.Length;
            int minIndis = 0;

            for(int i = 0; i < n; i++)
            {
                //minimum i olarak ayarlayalım
                minIndis = i;
                // i den sonraki tüm elemanları tarayalım
                for (int j = i + 1; j < n; j++)
                {
                    if (items[j] < items[minIndis])
                    {   //daha küçük eleman bulunursa indisini sakla
                        minIndis = j;
                    }

                }

                //en küçük indis değiştiyse takas işlemi gerçekleşir
                if(minIndis != i)
                {
                    int temp = items[i];
                    items[i] = items[minIndis];
                    items[minIndis] = temp;
                }
            }

            return items;
        }
    }
}

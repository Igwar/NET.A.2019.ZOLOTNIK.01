using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortArrayLibrary;
namespace SortArrayTest
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] x = new int[10];
            int[] y = new int[10];
            Random random = new Random();
            for (int i = 0; i < x.Length; i++) {
                
                x[i] = random.Next(1, 100);
               y[i] = random.Next(1, 100);
            }
            Console.WriteLine(" Не упорядоченный массив для быстрой сортировки: {0}", string.Join(", ", x));
            Console.WriteLine(" Не упорядоченный массив для сортировки слиянием: {0}", string.Join(", ", y));
            
            Console.WriteLine("Упорядоченный массив(быстрая): {0}", string.Join(", ", Sort.QuickSort(x)));
            Console.WriteLine("Упорядоченный массив(слияние): {0}", string.Join(", ", Sort.MergeSort(y)));
           
        }
    }
    }


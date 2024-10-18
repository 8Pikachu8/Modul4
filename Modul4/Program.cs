using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SumArr();
        }

        public static void Task4_3_7()
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            for (int i = name.Length - 1; i >=0; i--)
            {
                Console.Write(name[i] + " ");
            }

        }

        public static void Task4_3_11()
        {
            int[,] mass = { { 1, 2, 3, }, { 4, 5, 6 } };

            for (int i = 0; i <= mass.GetUpperBound(1); i++)
            {
                for (int j = 0; j <= mass.GetUpperBound(0); j++)
                {
                    Console.Write(mass[j, i] + " ");
                }
                Console.WriteLine();
            }

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }

        }

        public static void Task4_3_12()
        {
            Random rand = new Random();
            rand.Next(0, 10000);
             
            var arr = new int[100];

            for(int q = 0; q< arr.Length; q++)
            {
                arr[q] = rand.Next(0,1000);
            }
            //arr = SortVer1(arr);
            arr = SortVer2(arr);
            foreach (int a in arr)
            {
                Console.WriteLine(a + " ");
            }
        }

        public static int[] SortVer1(int[] arr) 
        {
            int i = 0;
            bool isSorted = true;
            while (true)
            {
                if (i == arr.Length - 1)
                {
                    i = 0;
                    if (isSorted)
                        break;
                    isSorted = true;
                }
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    isSorted = false;
                }
                i++;
            }
            return arr;
        }
        public static int[] SortVer2(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }

                }
            }


            return arr;
        }

        public static void SumArr()
        {
            Random rand = new Random();
            int[] arr = new int[100];
            int sum = 0;

            for (int q = 0; q < arr.Length; q++)
            {
                arr[q] = rand.Next(0, 1000);
            }


            foreach (int a in arr)
            {
                sum += a;
            }
            Console.WriteLine(sum);
        }

    }
}

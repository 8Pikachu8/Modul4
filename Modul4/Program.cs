using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task4_3_7();

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
    }
}

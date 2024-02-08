using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{public sealed class multidimensional : Array
    {
        public int[,] arrayyy;
        public multidimensional(int[,] array)
        {
            arrayyy = array;
        }
        public override void initialization()
        {
            for (int i = 0; i < arrayyy.GetLength(0); i++)
            {
                for (int j = 0; j < arrayyy.GetLength(1); j++)

                {

                    Console.Write($"Элемент [{i},{j}]: ");

                    arrayyy[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
        }
        public override void average_and_print()
        {
            int amount = 0;
            int sum = 0;

            for (int i = 0; i < arrayyy.GetLength(0); i++)
            {
                for (int j = 0; j < arrayyy.GetLength(1); j++)
                {
                    amount += 1;

                    sum += arrayyy[i, j];
                    Console.Write(arrayyy[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"среднее в многомерном массиве {sum / amount}");
        }
    }
}

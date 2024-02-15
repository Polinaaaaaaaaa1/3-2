using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3_2_наследование_
{
    public sealed class multidimensional : Array
    {
        public int[,] arrayyy;
        public int length;
        public int heigth;
        public multidimensional(int length, int heigth)
        {this.length = length;
            this.heigth = heigth;
            arrayyy = new int[length,heigth];
        }
        public override void initialization()
        {
            for (int i = 0; i < arrayyy.GetLength(0); i++)
            {
                for (int j = 0; j < arrayyy.GetLength(1); j++)

                {

                    Console.Write($"Элемент [{i},{j}]в многомерном массиве: ");

                    arrayyy[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
        }
        public override void average()
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
        public override void print()
        {
            for (int i = 0; i < arrayyy.GetLength(0); i++)
            {
                for (int j = 0; j < arrayyy.GetLength(1); j++)
                {
                    Console.Write(arrayyy[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3_2_наследование_
{
    abstract public class Array
    {
        public int[] array { get; set; }
        public abstract void initialization();
        public abstract void average_and_print();

    }

    public sealed class one_dimensional : Array
    {
        public int[] arrayyy;
        public one_dimensional(int[] array)
        {
            arrayyy = array;
        }
        public override void initialization()
        {
            for (int i = 0; i < arrayyy.Length; i++)
            {
                arrayyy[i] = int.Parse(Console.ReadLine());
            }
        }
        public override void average_and_print()
        {
            int amount = 0;
            int sum = 0;
            for (int i = 0; i < arrayyy.Length; i++)
            {
                amount += 1;
                sum += arrayyy[i];

            }
            Console.WriteLine($"среднее в одномерном массиве {sum / amount}");
            Console.WriteLine("\nодномерный массив : {0}", String.Join(" ", arrayyy));
        }

    }

    public sealed class multidimensional : Array
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

    public sealed class jagged : Array
    {
        public int[][] arrayyy;
        public jagged(int[][] arrayyy)
        {
            this.arrayyy = arrayyy;
        }
        public override void initialization()
        {
            Console.WriteLine("Введите ступенчатый массив");
            for (int i = 1; i <= arrayyy.GetLength(0); i++)
            {

                Console.WriteLine("Введите " + i + " строку массива");
                Console.WriteLine("введите количество элементов");

                int[] mas = new int[(int.Parse(Console.ReadLine()))];
                mas = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();

                arrayyy[(i - 1)] = mas;

            }
        }

        public override void average_and_print()
        {
            int amount = 0;
            int sum = 0;
            foreach (int[] i in arrayyy)
            {
                foreach (int elem in i)
                {
                    sum += 1;
                    amount += elem;
                    Console.Write(elem + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine($"среднее в зубчатом массиве {sum / amount}");
        }
    }
}

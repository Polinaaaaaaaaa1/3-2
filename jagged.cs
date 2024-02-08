using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3_2_наследование_

{public sealed class jagged : Array
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

}

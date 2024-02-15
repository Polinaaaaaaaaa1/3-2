using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3_2_наследование_
{
    public sealed class jagged : Array
    {
        public int[][] arrayyy;
        public int heigth;
        public jagged(int heigth)
        {this.heigth = heigth;  
            arrayyy = new int[heigth][];
        }
        public override void initialization()
        {
            for (int i = 1; i <= arrayyy.GetLength(0); i++)
            {
                Console.WriteLine($"введите количество элементов в {i} строке зубчатого массива"); 

                int[] mas = new int[(int.Parse(Console.ReadLine()))];
                Console.WriteLine("Введите " + i + " строку зубчатого массива");
                mas = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();

                arrayyy[(i - 1)] = mas;

            }
        }

        public override void average()
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
        public override void print()
        {
            Console.WriteLine("зубчатый массив");
            for (int i = 0; i < arrayyy.GetLength(0); i++)
            {
                Console.WriteLine(String.Join(" ", arrayyy[i]));

                
            }
        }
    }


}

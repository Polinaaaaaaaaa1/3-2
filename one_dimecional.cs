using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3_2_наследование_
{
        public sealed class one_dimensional : Array
        {
        public int[] arrayyy;
        public int length;
            public one_dimensional(int length)
            {
            this.length = length;
                arrayyy = new int[length];
            }
            public override void initialization()
            {
                for (int i = 0; i < arrayyy.Length; i++)
                {
                Console.WriteLine($"эл-т {i} в одномерном массиве");
                arrayyy[i] = int.Parse(Console.ReadLine());
                }
            }
            public override void average()
            {
                int amount = 0;
                int sum = 0;
                for (int i = 0; i < arrayyy.Length; i++)
                {
                    amount += 1;
                    sum += arrayyy[i];

                }
                Console.WriteLine($"среднее в одномерном массиве {sum / amount}");
            }
         public override void print()
        {

            Console.WriteLine("\nодномерный массив : {0}", String.Join(" ", arrayyy));
        }

    }
    
}

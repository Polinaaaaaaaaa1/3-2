using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace задание_3_2_наследование_
{
    internal class Program
    {
            static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           Console.WriteLine("введите длину массива 1");
           int length1 = int.Parse(Console.ReadLine());
            Array[] array1 = new Array[length1];

            Console.WriteLine("введите длину массива 2");
            int length2 = int.Parse(Console.ReadLine());
            one_dimensional array2 = new one_dimensional(new int[length2]);

            array2.initialization();
            array2.average_and_print();

            Console.WriteLine("введите длину массива 3");
            int length3 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите высоту массива 3");
            int heigth3 = int.Parse(Console.ReadLine());
            multidimensional array3 = new multidimensional(new int[length3,heigth3]);
            array3.initialization();
            array3.average_and_print();

            Console.WriteLine("введите количесвто строк зубчатого массива");
            int length4 = int.Parse(Console.ReadLine());
            jagged array4 = new jagged(new int[length4][]);
            array4.initialization();
            array4.average_and_print();
        }
    }
}
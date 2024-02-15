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
            

            Console.WriteLine("введите длину массива 2");
            int length2 = int.Parse(Console.ReadLine());
            one_dimensional array2 = new one_dimensional(length2);


            Console.WriteLine("введите длину массива 3");
            int length3 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите высоту массива 3");
            int heigth3 = int.Parse(Console.ReadLine());
            multidimensional array3 = new multidimensional(length3,heigth3);
            

            Console.WriteLine("введите количесвто строк зубчатого массива");
            int length4 = int.Parse(Console.ReadLine());
            jagged array4 = new jagged(length4);
            Array[] arrays = { array2, array3, array4 };
            for (int i = 0;i< arrays.Length; i++)
            {
                arrays[i].initialization();
                arrays[i].average();
                arrays[i].print();
            }
        } 
            
        
    
    }
}

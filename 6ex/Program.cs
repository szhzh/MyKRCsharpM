using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ex
{
    class Program
    {
        static void Main(string[] args)//даден е масив 'a' с 'n' елемента и число 'c'.Да се намерят всички елементи в масива, равни на числото 'c', тясната сума и тяхното произведениел
        {
            
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a["+i+"]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter a number that you will search in the array: ");
            int c = int.Parse(Console.ReadLine());
            int sum = 0;
            int product = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (c == a[i])
                {
                    Console.WriteLine("a["+i+"]= {0}",a[i]);
                    sum = sum + a[i];
                    product = product * a[i];
                }
                
            }
            Console.WriteLine("the sum of the elements that are equals to your number is: "+sum);
            Console.WriteLine("the product of the elements that are equals to your number is: " + product);
        }
    }
}

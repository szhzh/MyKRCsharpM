using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ex
{
    class Program
    {
        static void Main(string[] args) //dali chisloto e prosto 
        {
            Console.Write("Enter a integer number: ");
            int num = int.Parse(Console.ReadLine());
            if (num /10 ==0)
            {
                if (num == 2 || num == 3 || num == 5 || num == 7)
                {
                    Console.WriteLine("The number is simle !");
                }
                else
                {
                    Console.WriteLine("The number is not simle !");
                }
            }
            else
            {
                if (num % 2 > 0 && num % 3 > 0 && num % 5 > 0 && num % 7 > 0)
                {
                    Console.WriteLine("The number is simple !");
                }
                else
                {
                    Console.WriteLine("The number is not simple !");
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFacNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1016;
            string binary = Convert.ToString(num, 2);
            string octa = Convert.ToString(num, 8);
            string hex = Convert.ToString(num, 16);
            Console.WriteLine("My faculty number: "+num+"\nbinary- "+binary+"\nocta- "+octa+"\nhexadecimal- "+hex);
            
        }
    }
}

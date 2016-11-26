using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ex
{
    class Program
    {
        static void Main(string[] args) // presmetni obema na presecheniq konus kato vuvedesh H,R,r 
        {
            Console.Write("The high of the truncated cone is: ");
            int high = int.Parse(Console.ReadLine());
            Console.Write("The big radius of the truncated cone is: ");
            int brad = int.Parse(Console.ReadLine());
            Console.Write("The little radius of the truncated cone is: ");
            int lrad = int.Parse(Console.ReadLine());
            double formula = Math.PI * high * (brad * brad + brad * lrad + lrad * lrad) / 3;
            Console.WriteLine("The volume of the truncated cone is: {0:f2} ",formula);
        }
    }
}

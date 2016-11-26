using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ex
{
    class Program
    {
        static void Main(string[] args) //dai stoinost na k v trite izraza i presmetni
        {
            Console.WriteLine("You have the mathematic system:");
            Console.WriteLine("   (6.7               1)");
            Console.WriteLine("y= {6.7 + 9*k         2)");
            Console.WriteLine("   (6.7 + 9*k+ 7*k*k  3)");

            Console.Write("Give a value to the parameter 'k' for the first statement: ");
            int k1 = int.Parse(Console.ReadLine());
            double k1result = 6.7 + k1 * 0;
            Console.WriteLine("And the result of the first statement is: ");
            Console.WriteLine(k1result);

            Console.Write("Give a value to the parameter 'k' for the second statement: ");
            int k2 = int.Parse(Console.ReadLine());
            double k2result = 6.7 + 9*k2;
            Console.WriteLine("And the result of the second statement is: ");
            Console.WriteLine(k2result);

            Console.Write("Give a value to the parameter 'k' for the third statement: ");
            int k3 = int.Parse(Console.ReadLine());
            double k3result = 6.7 + 9*k3+ 7*k3*k3;
            Console.WriteLine("And the result of the third statement is: ");
            Console.WriteLine(k3result);
        }
    }
}

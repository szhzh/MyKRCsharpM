using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ex
{
    class Program
    {
        static void Main(string[] args)//да се изчисли функцията f(n)= 1+1/2^4+1/3^4+...+1/n^4- kato vuvedem dve chisla a i b i presmetnem F(a+b) i F(|a-b|)
        {
            Console.WriteLine("Look at the function: ");
            Console.WriteLine("f(n)= 1+1/2^4+1/3^4+...+1/n^4");
            Console.WriteLine("You will have to enter two integer positive numbers 'a' and 'b'\nand i will evaluate F(a+b)*F(|a-b|)");
            Console.Write("Enter 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter 'b': ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int dif = a - b;
            if (dif < 0)
            {
                dif = -(dif);
            }
            double fsum=0;
            for (int i = 1; i < sum; i++)
            {
                if (fsum == 1)
                {
                    fsum = 1;
                }
                else
                {
                    fsum = fsum + (double)1 / Math.Pow(i, 4);
                }
                fsum = fsum + 1 /Math.Pow(i, 4);
            }
            double fdif = 0;
            for (int i = 1; i < dif; i++)
            {

                if (dif == 1)
                {
                    fdif = 1;
                }
                else
                {
                    fdif = fdif + (double)1 / Math.Pow(i, 4);
                }
            }
            double result = fsum*fdif;
            Console.WriteLine("F(a+b)*F(|a-b|)= {0}*{1}= {2}", fsum, fdif, result );
            Console.WriteLine("F(a+b)*F(|a-b|)= {0:f2}*{1:f2}= {2:f2}", fsum, fdif, result);

        }
    }
}

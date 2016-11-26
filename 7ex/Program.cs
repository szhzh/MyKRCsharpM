using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string[] cities = new string[] { "Попово", "София", "Созопол", "Шумен", "Пловдив", "Тополовград", "Силистра", "Варна" };
            int counter = 0;
            Console.WriteLine("The cities that contain more than two 'o' are: ");
            for (int i = 0; i < cities.Length; i++)
            {
                for (int s = 0; s < cities[i].Length; s++)
                {
                    char compare = 'о';
                    if (cities[i][s].CompareTo(compare)==0)
                    {
                        counter = counter + 1;
                        if (counter > 2)
                        {
                            Console.WriteLine("- "+ cities[i]);
                            counter = 0;
                        }
                    }
                }

                
            }
        }
    }
}

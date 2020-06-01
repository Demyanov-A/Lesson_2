using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 234;
            int c = 345;

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }

            Console.ReadKey();
        }
    }
}

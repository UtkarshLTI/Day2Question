using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        void Prime(int a,int b)
        {
            for (int i = a; i <= b; i++)
            {
                int ctr = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && i != 1)
                    Console.Write("{0} ", i);
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. 1");
            int no1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no. 2");
            int no2 = Convert.ToInt32(Console.ReadLine());
            new Program().Prime(no1,no2);
            Console.ReadKey();
        }
    }
}

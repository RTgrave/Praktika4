using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Praktika4
{
    class Program
    {
        static void Main(string[] args)
        {
            double next_iter = 0;
            double equt_num = ChooseEqut();
            if (equt_num == 1)
            {
                Console.WriteLine(First());
                Console.WriteLine("Continue?");
                next_iter = Convert.ToDouble(Console.ReadLine());
                if(next_iter == 1)
                {
                    ChooseEqut();
                }
                else if(next_iter == 0)
                {
                    Environment.Exit(0);
                }
            }
            else if( equt_num == 13)
            {
                Console.WriteLine(Second());
                Console.WriteLine("Continue?");
                next_iter = Convert.ToDouble(Console.ReadLine());
                if (next_iter == 1)
                {
                    ChooseEqut();
                }
                else if (next_iter == 0)
                {
                    Environment.Exit(0);
                }
            }



            Console.ReadKey();
        }

    static double ChooseEqut()
    {
        Console.WriteLine("Which equtation you want to do");
        double choosen_task = 0;
        choosen_task= Convert.ToDouble(Console.ReadLine());
            return choosen_task;
    }

        static double First()
        {
            double c, d, a;
            double res_first = 0; ;
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            a = Convert.ToDouble(Console.ReadLine());

            c = c * 2;
            a = a / 4;
            c = c - d;
            res_first = (c + Math.Sqrt(23)) / a;

            return res_first;
        }

        static double Second()
        {
            double c, d, a;
            double res_second = 0;
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            a = Convert.ToDouble(Console.ReadLine());
            c = Math.Atan(c - d / 2);
            a = 2 * a;
            a = a - 1;
            res_second = c / a;
            return res_second;
        }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static double ReadAnswer()
        {
            double a = 0;
            bool ok = false;
            do
            {
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Пожалуйста, введите действительное число.");
                    ok = false;
                }
            } while (!ok);
            return a;
        }

        static void Main(string[] args)
        {
                double x = 0;
                double y = 0;

                Console.WriteLine("Введите x");
                x = ReadAnswer();
                Console.WriteLine("Введите y");
                y = ReadAnswer();

                bool t1 = y > 0 && x >= -1.5 && y <= -x;
            bool t2 = x <= 1 && x >= -2 && y <= 2 * x + 3 && y >= 1.0 / 3 * x - 1.0 / 3 && y <= 0;
                bool r = t1 || t2;
                Console.WriteLine(r);
           

        }
    }
}

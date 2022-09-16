using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R1 = 0;
            double R2 = 0;
            double R = 0;
            bool isR1ok = false;
            bool isR2ok = false;

            do
            {
                Console.WriteLine("Введіть опір першого резистора (R1): ");
                string strR1 = Console.ReadLine();
                isR1ok = double.TryParse(strR1, out R1);
                if (!isR1ok || R1 < 0)
                {
                    Console.WriteLine("Неправильно введений опір!");
                }
            } while (!isR1ok || R1 < 0);

            do
            {
                Console.WriteLine("Введіть опір другого резистора (R2): ");
                string strR2 = Console.ReadLine();
                isR2ok = double.TryParse(strR2, out R2);
                if (!isR2ok || R2 < 0)
                {
                    Console.WriteLine("Неправильно введений опір!");
                }
            } while (!isR2ok || R2 < 0);

            R = (R1 * R2) / (R1 + R2);
            Console.WriteLine("Опір двох паралельно з'єднаних резисторів: " + Math.Round(R, 2));
            Console.WriteLine("Натисніть будь-яку клавішу для того, щоб продовжити...");
            Console.ReadKey();
        }
    }
}

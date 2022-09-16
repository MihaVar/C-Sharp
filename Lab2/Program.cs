using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nn = 0;
            double nk = 0;
            double sum = 0;
            bool isNNOk = false;
            bool isNKOk = false;

            do
            {
                Console.WriteLine("Ввелідь змінну nn: ");
                string strnn = Console.ReadLine();
                isNNOk = double.TryParse(strnn, out nn);
                if (!isNNOk || nn < 0)
                {
                    Console.WriteLine("Неправильно задана змінна!");
                }
            } while (!isNNOk || nn < 0);

            do
            {
                Console.WriteLine("Введіть змінну nk: ");
                string strnk = Console.ReadLine();
                isNKOk = double.TryParse(strnk, out nk);
                if (!isNKOk || nk < 0)
                {
                    Console.WriteLine("Неправильно задана змінна!");
                }
                else if (nn > nk)
                {
                    Console.WriteLine("Змінна повинна бути більшою за попередню!");
                }
            } while (!isNKOk || nk < 0 || nn > nk);

            for (double k = nn; k < nk; k++)
            {
                sum += ((Math.Pow(nk, 2) - 1) / (Math.Pow(-1, nk + 1) * Math.Pow(nk, 2) + 7));
            }
            Console.WriteLine("Сума ряду: " + sum);
            Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }
    }
}

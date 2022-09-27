using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool isNOk = false;
            bool isNtrue;
            
            do
            {
                Console.WriteLine("Ввелідь змінну n: ");
                string strn = Console.ReadLine();
                isNOk = int.TryParse(strn, out n);
                if (!isNOk)
                {
                    Console.WriteLine("Неправильно задана змінна!");
                }
            } while (!isNOk);

            if (n % 2 == 0 && (n-10) > 0) //перевірка на те, чи є число парним та двозначним
            {
                isNtrue = true;
                
            }
            else
            {
                isNtrue = false;
                
                
            }
            Console.WriteLine(isNtrue);
            Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();

        }
    }
}

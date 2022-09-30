using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {

        
        static void Main()
        {
            int m, n; 
            Console.WriteLine("Введіть розмірність масиву (рядки х стовбці): ");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n]; //масив із вказаною розмірністю
            int max = 0, min = 0, id1, id2, tmp;
            Random rn = new Random();
            for (int i = 0; i < m; i++) //генерація масиву
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rn.Next(0, 50);
                }
            }
            Console.WriteLine("Оригінальний масив: " + "\n");
            for (int i = 0; i < m; i++) //вивід масиву
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0,3}", arr[i, j]));
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++) //заміна мінімального й максимального елементів у стовпчиках
            {
                max = arr[0, i];
                id1 = 0;
                min = arr[0, i];
                id2 = 0;
                for (int j = 0; j < m; j++) //безпосередня заміна елементів
                {
                    if (arr[j, i] > max)
                    {
                        max = arr[j, i];
                        id1 = j;
                    }
                    if (arr[j, i] < min)
                    {
                        min = arr[j, i];
                        id2 = j;
                    }
                }
                tmp = arr[id1, i];
                arr[id1, i] = arr[id2, i];
                arr[id2, i] = tmp;
            }
            Console.WriteLine("Змінений масив: " + "\n");

            for (int i = 0; i < m; i++) //виведення зміненого масиву
            {
                for (int j = 0; j < n; j++)
                    Console.Write(String.Format("{0,3}", arr[i, j]));
                Console.WriteLine();
            }
            Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }
      
}
}


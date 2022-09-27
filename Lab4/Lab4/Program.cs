using System;

internal class Program
{
    static void Main()
    {

        int n;
        bool isNOk = false;
        do //введення розміру масиву
        {
            Console.WriteLine("Введіть розмір масиву (N): ");
            string strn = Console.ReadLine();
            isNOk = int.TryParse(strn, out n);
            if (!isNOk || n < 0)
            {
                Console.WriteLine("Неправильне значення!");
            }
        } while (!isNOk || n < 0);
        int[] arr = new int[n];
        Console.Write("Введіть елементи масиву: ");
        Console.Write("\n");
        for (int i = 0; i < n; i++) //введення елементів масиву
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i <= n - 1; i++) //вивід непарних
        {
            if (arr[i] % 2 != 0)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
        }
        for (int i = 0; i <= n - 1; i++) //вивід парних
        {
            if (arr[i] % 2 == 0)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
        }
        Console.WriteLine("\n");
        Console.WriteLine("Натисніть будь-яку клавішу для того, щоб продовжити...");
        Console.ReadKey();
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        int N, count = 0;
        Console.WriteLine("Enter amount of elements in array: ");
        N = int.Parse(Console.ReadLine()); //вводимо кількість елементів в масиві
        Console.WriteLine("Enter array elements: " + "\n");
        int[] arr = new int[N]; //створення масиву з розміром, який ми вказали
        for (int i = 0; i < arr.Length; i++) //заповнення масиву
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] < 0) count++; //запис елементів, що менше нуля
        }
        Console.WriteLine("Amount of negative elements: " + count); //вивід елементів менше нуля
        Console.WriteLine("Press any button to quit from program...");
        Console.ReadKey();
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int N, count = 0;
        Console.WriteLine("Enter amount of elements in array: ");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array elements: " + "\n");
        int[] arr = new int[N];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] < 0) count++;
        }
        Console.WriteLine("Amount of negative elements: " + count);
        Console.WriteLine("Press any button to quit from program...");
        Console.ReadKey();
    }
}

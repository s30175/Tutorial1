// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

static double CalculateAverage(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}

int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine(CalculateAverage(arr));
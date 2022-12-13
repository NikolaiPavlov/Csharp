//Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и 
//последнюю строку массива.

Console.Clear();
Console.Write("Введите число строк массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m, n, 1, 10);

PrintArray(array);

PrintArray(SwapRow(array));

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] >= 0 ? $"  {arr[i, j]}" : $" {arr[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] SwapRow(int[,] arr)
{
    Console.WriteLine();
    int exchange = 0;
    int[,] resultArray = (int[,])arr.Clone();
    for (int i = 0; i < resultArray.GetLength(1); i++)
    {
        exchange = resultArray[0, i];
        resultArray[0, i] = resultArray[resultArray.GetLength(0) - 1, i];
        resultArray[resultArray.GetLength(0) - 1, i] = exchange;
    }
    return resultArray;
}

int[,] FillArray(int rowArray, int colArray, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rowArray, colArray];
    for (int i = 0; i < rowArray; i++)
        for (int j = 0; j < colArray; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    return resultArray;
}


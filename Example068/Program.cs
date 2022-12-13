//Задача 49: Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты

Console.Clear();
Console.Write("Введите число строк массива : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(row, column, -9, 9);

PrintArray(array);

PrintArray(SetSquare(array));


int[,] SetSquare(int[,] arr)
{
    int[,] resultArray = (int[,])arr.Clone();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) resultArray[i, j] = resultArray[i, j] * resultArray[i, j];
        }
    }
    return resultArray;
}
void PrintArray(int[,] arr)
{
    Console.WriteLine("----------------------------");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] >= 0 ? $"  {arr[i, j]}" : $" {arr[i, j]}");
        }
        Console.WriteLine();
    }
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


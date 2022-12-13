//Задача 47
//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество стобцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

double[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    double[,] filledArray = new double[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = minValue + random.NextDouble() * (maxValue - minValue);
        }
    }

    return filledArray;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}



double[,] array = FillArray(rows, columns, min, max);

PrintArray(array);

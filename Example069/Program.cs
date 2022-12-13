//Задача 50
//Напишите программу, которая на вход принимает индексы 
//элемента в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.

Console.Clear();

//Console.WriteLine("Введите количество строк двумерного массива");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество стобцов двумерного массива");
//int columns = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите минимальное возможное значение в двумерном массиве");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите максимальное возможное значение в двумерном массиве");
//int max = Convert.ToInt32(Console.ReadLine());

int rows = 10;
int columns = 10;
int min = 0;
int max = 9;

Console.WriteLine($"Введите индекс строки в диапозоне [0, {rows}] в двумерном массиве");
int findRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите индекс столбца в диапозоне [0, {columns}] в двумерном массиве");
int findColumn = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }

    return filledArray;
}

void PrintArray(int[,] inputArray)
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

void FindElementInArray(int[,] inputArray, int arrayRow, int arrayColumn)
{
    Console.WriteLine(inputArray[arrayRow, arrayColumn]);
}

int[,] array = FillArray(rows, columns, min, max);

//PrintArray(array);

FindElementInArray(array, findRow, findColumn);
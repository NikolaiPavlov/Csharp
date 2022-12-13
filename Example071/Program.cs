//Задача 52
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество стобцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());


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

void FindMedianInColumn(int[,] inputArray)
{
    Console.WriteLine();

    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        double mediana = 0;

        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            mediana += inputArray[i, j]; 
        }
        double result = mediana / inputArray.GetLength(0);
        
        Console.Write(result + " ");
    }
}

int[,] array = FillArray(rows, columns, min, max);

PrintArray(array);

FindMedianInColumn(array);

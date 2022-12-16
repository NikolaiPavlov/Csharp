//Задача 56
//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.


Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
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

int SumLineElements(int[,] inputArray, int i)
{
  int sumLine = inputArray[i,0];
  for (int j = 1; j < inputArray.GetLength(1); j++)
  {
    sumLine += inputArray[i,j];
  }
  return sumLine;
}

void FindMinSumLine(int[,] inputArray)
{
    int minSumLine = 0;
    int sumLine = SumLineElements(inputArray, 0);
    for (int i = 1; i < inputArray.GetLength(0); i++)
    {
    int tempSumLine = SumLineElements(inputArray, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
    }

    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
}

int[,] array = FillArray(rows, columns, min, max);

PrintArray(array);

FindMinSumLine(array);

//Задача 51: Задайте двумерный массив. Найдите сумму
//элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.

Console.Clear();
Console.Write("Введите число строк массива : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(row, column, -9, 9);

PrintArray(array);

Console.WriteLine($"Сумма элементов главной диагонали = {GetDiagonalSumm(array)}");

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


int GetDiagonalSumm(int[,] array)
{
    int sum = 0;
    for(int i = 0;i< array.GetLength(0);i++)
    {
        for(int j = 0;j<array.GetLength(1);j++)
        {
            if(i==j)
                sum += array[i,j];
        }
    }
    return sum;
}

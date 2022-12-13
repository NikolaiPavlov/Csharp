//Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.


Console.Clear();

Console.Write("Введите число строк массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m, n);

PrintArray(array);

void PrintArray(int[,] arr) {
   for (int i = 0; i < arr.GetLength(0); i++)
   {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] >= 0 ? $"  {arr[i,j]}" : $" {arr[i,j]}");
        }    
        Console.WriteLine();
   }
}

int[,] FillArray(int rowArray, int colArray)
{
    int[,] resultArray = new int[rowArray, colArray];
    for (int i = 0; i < rowArray; i++)
        for (int j = 0; j < colArray; j++)
        {
            resultArray[i,j] = i + j;
        }
    return resultArray;
}
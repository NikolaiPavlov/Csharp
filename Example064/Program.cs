//Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью 
//поэлементного копирования.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());


int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();

    int[] resultArray = new int[sizeArray];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }

    return resultArray;
}

int[] CopyArray(int[] inputArray)
{
    int[] copyArray = new int[inputArray.Length];

    for(int i = 0; i < inputArray.Length; i++)
    {
        copyArray[i] = inputArray[i];
    }
    return copyArray;
}

int[] array = FillArray(size, min, max);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Копия массива: [{string.Join(", ", CopyArray(array))}]");
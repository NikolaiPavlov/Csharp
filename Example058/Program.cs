//Задача 39: Напишите программу, которая перевернёт 
//одномерный массив (последний элемент будет на 
//первом месте, а первый - на последнем и т.д.)

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

int[] ReverseArray(int[] inputArray)
{
    int[] reverseArray = new int[inputArray.Length];

    for (int i = 0; i < inputArray.Length; i++)
    {
        reverseArray[i] = inputArray[inputArray.Length - i - 1];
    }
    return reverseArray;
}

int[] array = FillArray(size, min, max);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Перевернутый массив: [{string.Join(", ", ReverseArray(array))}]");
Console.WriteLine($"Перевернутый массив: [{string.Join(", ", array.Reverse())}]");

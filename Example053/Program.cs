//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов 
//массива.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
Console.WriteLine($"Получившийся массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {FindMaxAndMinInArray(array).Item1 - FindMaxAndMinInArray(array).Item2}");

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

(int, int) FindMaxAndMinInArray(int[] inputArray)
{
    int max = inputArray[0];
    int min = inputArray[0];

    for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i] > max)
        {
            max = inputArray[i];
        }
        if(inputArray[i] < min)
        {
            min = inputArray[i];
        }
    }

    return (max, min);
}

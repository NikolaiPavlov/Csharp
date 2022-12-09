//Задача 32: Напишите программу замена элементов 
//массива: положительные элементы замените на 
//соответствующие отрицательные, и наоборот.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
Console.WriteLine($"Получившийся массив: [{string.Join(", ", array)}]");
array = ChangeSignByArray(array, size);
Console.WriteLine($"Получившийся массив: [{string.Join(", ", array)}]");


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

int[] ChangeSignByArray(int[] inputArray, int sizeArr)
{
    int[] outputArray = new int[sizeArr];

    for (int i = 0; i < inputArray.Length; i++)
    {
        outputArray[i] = inputArray[i] * -1;
    }

    return outputArray;
}
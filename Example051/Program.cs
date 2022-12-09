//Задача 36
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
Console.WriteLine($"Получившийся массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Сумма чисел в массиве стоящих на нечетных позициях: {FindSumNegativePositionsInArray(array)}");

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

int FindSumNegativePositionsInArray(int[] inputArray)
{
    int sum = 0;

    for(int i = 0; i < inputArray.Length; i = i + 2)
    {
        sum += inputArray[i];
    }

    return sum;
}



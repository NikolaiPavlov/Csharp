//Задача 31
//Задайте массив из 12 элементов, заполненный 
//случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных 
//элементов массива.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
Console.WriteLine($"Получившийся массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Сумма положительных элементов в массиве: {FindSumPositiveAndNegativeByArray(array).Item1}");
Console.WriteLine($"Сумма отрицательных элементов в массиве: {FindSumPositiveAndNegativeByArray(array).Item2}");


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

(int, int) FindSumPositiveAndNegativeByArray(int[] inputArray)
{
    int sumPositiveValues = 0;
    int sumNegativeValues = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > 0)
        {
            sumPositiveValues += inputArray[i];
        }
        else
        {
            sumNegativeValues += inputArray[i];
        }
    }
    return (sumPositiveValues, sumNegativeValues);
}


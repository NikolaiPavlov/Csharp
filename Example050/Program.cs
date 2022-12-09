//Задача 35
//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых 
//лежат в отрезке [10,99]. 

Console.Clear();

int[] array = FillArray();
Console.WriteLine($"Получившийся массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Количество четных чисел в массиве: {FindValueInArray(array)}");

int[] FillArray()
{
    Random random = new Random();

    int[] resultArray = new int[123];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(0, 1000);
    }

    return resultArray;
}

int FindValueInArray(int[] inputArray)
{
    int count = 0;

     for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i] >= 10 && inputArray[i] <= 99)
        {
            count++;
        }
    }

    return count;
}


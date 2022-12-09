//Задача 34
//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая 
//покажет количество чётных чисел в массиве.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size);
//Console.WriteLine($"Получившийся массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Количество четных чисел в массиве: {FindEvenNumbersByArray(array, size)}");

int[] FillArray(int sizeArray)
{
    Random random = new Random();

    int[] resultArray = new int[sizeArray];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(100, 1000);
    }

    return resultArray;
}

int FindEvenNumbersByArray(int[] inputArray, int sizeArray)
{
    int count = 0;

    for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}


//Задача 33
//Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для поиска в массиве");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
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

bool FindNumberInArray(int[] inputArray, int num)
{
    for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i] == num)
        {
            return true;
        }
    }
    return false;
}

if(FindNumberInArray(array, number) == true)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");


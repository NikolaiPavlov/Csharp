//Задача 37
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и 
//предпоследний и т.д. Результат запишите в новом массиве.

Console.Clear();
Console.Write("Введите число элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, 1, 9);

Console.WriteLine($"Оригинальный массив:    [ {string.Join(", ", array)} ]");
Console.WriteLine($"Получившийся массив:    [ {string.Join(", ", GetMultiplyArray(array))} ]");



int[] GetMultiplyArray(int[] inputArray)
{

    int arrLength = inputArray.Length / 2;
    if (inputArray.Length % 2 != 0) arrLength++;

    int[] multipleArray = new int[arrLength];

    for (int i = 0; i < arrLength; i++)
    {
        multipleArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if(inputArray.Length % 2 != 0) multipleArray[multipleArray.Length - 1] = inputArray[multipleArray.Length - 1];

    return multipleArray;
}


int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}



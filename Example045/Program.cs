//Задача 30: Напишите программу, которая выводит 
//массив из 8 элементов, заполненный нулями и 
//единицами в случайном порядке.

Console.Clear();

int[] FillArray(int n)
{
    Random rnd = new Random();
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

int[] arr = FillArray(8);

Console.WriteLine(string.Join(" ", arr));
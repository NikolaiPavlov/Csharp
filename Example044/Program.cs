//Задача 29
//Напишите программу, которая задаёт массив 
//из N элементов и выводит их на экран.

Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int n)
{
    Random rnd = new Random();
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

int[] arr = FillArray(number);

Console.WriteLine(string.Join(" ", arr));
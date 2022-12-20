//Задача 66
//Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке 
//от M до N с помощью рекурсии.

Console.Clear();

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int FindSum(int min, int max)
{
    if (min > max) return 0;
    return min + FindSum(min+1, max);
}

Console.WriteLine(FindSum(m, n));
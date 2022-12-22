// Задача 63: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке 
//от 1 до N с помощью рекурсии

Console.Clear();

Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

PrintValue(1, n);

void PrintValue(int m, int max)
{
    if (m > max) return;
    Console.Write($" {m}");
    PrintValue(m + 1, max);
}

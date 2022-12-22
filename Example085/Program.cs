//Задача 65: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке 
//от M до N с помощью рекурсии

Console.Clear();
Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}, N = {n} ->");
PrintValue(m, n);

void PrintValue(int val, int max)
{
    if (val > max) return;
    Console.Write($" {val}");
    PrintValue(val + 1, max);
}

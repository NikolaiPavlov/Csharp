//Задача 64
//Задайте значения M и N. Напишите программу, 
//которая выведет все чётные натуральные числа в промежутке 
//от M до N с помощью рекурсии.

Console.Clear();

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void FindEvenNumbers(int min, int max)
{
    if (min > max) return;
    if (min % 2 == 0 && min <= max) Console.Write($"{min} ");
    FindEvenNumbers(min + 1, max);
}

FindEvenNumbers(m, n);
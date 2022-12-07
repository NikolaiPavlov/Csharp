//Задача 22
//Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count < n)
{
    Console.Write($"{count * count}, ");
    count++;
}
Console.Write(n * n);
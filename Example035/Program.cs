//Задача 23
//Напишите программу, которая принимает на вход 2 числа 
//(N,M) и выдаёт таблицу кубов чисел от N до M.

Console.Clear();

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

int count = n;

while (count < m)
{
    Console.Write($"{Math.Pow(count, 3)}, ");
    count++;
}
Console.Write(Math.Pow(m, 3));
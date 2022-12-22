//Задача 69: Напишите программу, которая на вход принимает 
//два числа A и B, и возводит число А в целую степень B 
//с помощью рекурсии.

Console.Clear();
Console.Write("Введите число A : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"{a} в степени {b} равно {CalculatePow(a, b)}");

int CalculatePow(int a, int b)
{
    if (b == 0) return 1;
    return a * CalculatePow(a, b - 1);  // a^n = a * a^n-1 .... a^5 = a * a * a * a * a * 1  .... a^0 = 1
}
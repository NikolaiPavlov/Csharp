//Задача 40: Напишите программу, которая принимает 
//на вход три числа и проверяет, может ли существовать 
//треугольник с сторонами такой длины.

Console.Clear();

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) return true;
    else return false;
}

Console.WriteLine(CheckTriangle(number1, number2, number3));
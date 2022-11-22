// Напишите программу, которая
// выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);

Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");

int n1 = number / 10;
int n2 = number % 10;

if (n1 > n2) Console.WriteLine(n1);
else if (n2 > n1) Console.WriteLine(n2);
else Console.WriteLine("Цифры равны");
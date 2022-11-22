//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли первое число
//кратным второму. Если число 1 не кратно числу 2, то
//программа выводит остаток от деления.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0) Console.WriteLine("Кратно");
else
{
    int result = number1 % number2;
    Console.WriteLine($"Не кратно, остаток {result}");
}
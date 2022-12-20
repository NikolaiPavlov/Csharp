//Задача 68
//Задайте значения M и N. Напишите программу, 
//которая найдёт наибольший общий делитель (НОД) этих чисел 
//с помощью рекурсии.

Console.Clear();

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int FindGCF(int number1, int number2)
{
    if (number1 >= number2)
    {
        if (number1 % number2 == 0) return number2;
        return FindGCF(number1, number2 - 1);
    }
    else
    {
        if (number2 % number1 == 0) return number1;
        return FindGCF(number1 - 1, number2);
    }
}

Console.WriteLine(FindGCF(n, m));
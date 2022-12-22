//Задача 67: Напишите программу, которая будет принимать 
//на вход число и возвращать сумму его цифр с помощью рекурсии.

Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {n} равна {CalculateSummOfDigits(n)}");

int CalculateSummOfDigits(int val)
{
    if (val == 0) return 0;
    int summ = val % 10;
    summ += CalculateSummOfDigits(val / 10);
    return summ;
    // return val % 10 + CalculateSummOfDigits(val / 10);
}

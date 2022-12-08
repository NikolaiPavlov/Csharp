// Задача 24: Напишите программу, 
//которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.

Console.Clear();

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма от 1 до числа {number} = {FindSumToLimit(number)}");

int FindSumToLimit(int limit)
{
    int sum = 0;

    for (int i = 0; i < limit + 1; i++)
    {
        sum += i;
    }

    return sum;
}
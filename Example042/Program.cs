//Задача 27
//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int FindLength(int a)
{
    int length = 0;

    while (a > 0)
    {
        a = a / 10;
        length++;
    }
    return length;
}

int FindSum(int a)
{
    int sum = 0;
    for(int i = 0; i < FindLength(number); i++)
    {
       int b = a % 10;
        a = a / 10;
    sum = sum + b; 
    }
    return sum;
}

Console.WriteLine(FindSum(number));
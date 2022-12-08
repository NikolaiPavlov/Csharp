//Задача 26: Напишите программу, которая 
//принимает на вход число и выдаёт количество 
//цифр в числе.

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

Console.WriteLine(FindLength(number));
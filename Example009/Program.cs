Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine($"Да, число {number1} является квадратом числа {number2}");
}
else Console.WriteLine($"Нет, число {number1} неявляется квадратом числа {number2}");
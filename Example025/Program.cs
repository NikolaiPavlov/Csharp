//Задача 13

//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций 
//(целочисленное деление, остаток от деления).

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 1000)
    {
        number = number/10;
    }
    int result = number%10;
    Console.WriteLine(result);
}
else Console.WriteLine("Третьей цифры нет");
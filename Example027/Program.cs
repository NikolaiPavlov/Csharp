//Задача 15

//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным.

Console.WriteLine("Введите цифру от 1 до 7: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number > 5) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Число не соответствует дню недели");
// Задача 19
//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли 
//оно палиндромом.

Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n>9999 && n<100000)
{
    if(
        n/10000 == n%10 && 
        (n/1000)%10 == (n%100)/10
    ) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Это не пятизначное число") ;
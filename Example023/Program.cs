//Напишите программу, которая выводит случайное
//трехзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int n1 = number / 100;
int n2 = number % 10;
int result = (n1 * 10) + n2;

Console.WriteLine(result);
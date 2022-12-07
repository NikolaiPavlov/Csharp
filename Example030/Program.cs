//Задача 18
//Напишите программу, которая по заданному номеру 
//четверти, показывает диапазон возможных координат 
//точек в этой четверти (x и y).

Console.Clear();

Console.WriteLine("Введите номер четверти: ");
int n = int.Parse(Console.ReadLine());

if (n > 4 || n < 1) Console.WriteLine("Не соблюдено условие");
else if (n == 1) Console.WriteLine("X > 0, Y > 0");
else if (n == 2) Console.WriteLine("X < 0, Y > 0");
else if (n == 3) Console.WriteLine("X < 0, Y < 0");
else Console.WriteLine("X > 0, Y < 0");
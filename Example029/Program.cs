//Задача 17
//Напишите программу, которая принимает на вход 
//координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

Console.Clear();

Console.WriteLine("Введите X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0) Console.WriteLine("Не соблюдено условие");
else if (x > 0 && y > 0) Console.WriteLine("1");
else if (x < 0 && y > 0) Console.WriteLine("2");
else if (x < 0 && y < 0) Console.WriteLine("3");
else Console.WriteLine("4");
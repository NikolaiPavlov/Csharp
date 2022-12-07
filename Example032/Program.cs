//Задача 20
//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними 
//в 2D пространстве.

Console.Clear();

Console.WriteLine("Введите координату Х точки A");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки A");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки B");
int yB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xB-xA, 2)+Math.Pow(yB-yA, 2));
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));
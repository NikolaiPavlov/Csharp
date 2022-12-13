//Задача 43
//Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
//пользователем.

Console.Clear();

Console.WriteLine("Введите b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToInt32(Console.ReadLine());


(double, double) FindDotOnTwoLines(double ba, double ka, double bb, double kb)
{
    double x = (bb - ba) 
             / (ka - kb);
    double y = ka * x + ba;
    return (x, y);
}

Console.WriteLine($"Точка пересечения прямых: ({FindDotOnTwoLines(b1, k1, b2, k2).Item1}; {FindDotOnTwoLines(b1, k1, b2, k2).Item2})");
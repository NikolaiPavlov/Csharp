//Нахождение факториала с помощью рекурсии

Console.Clear();

Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

int FindFactorial(int n)
{
    if (n == 1 || n == 0) return 1;

    return n * FindFactorial(n-1);
}

Console.WriteLine($"Факториал числа {value} = {FindFactorial(value)}");


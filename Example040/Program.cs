//Задача 25
//Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A 
// натуральную степень B.

Console.Clear();

Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(exponentiation(number1, number2));

int exponentiation(int a, int b)
{
    int exp = 1;

    for (int i = 0; i < b; i++)
    {
        exp = exp * a;
    }

    return exp;
}
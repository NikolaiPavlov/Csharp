//Задача 28: Напишите программу, которая принимает 
//на вход число M и N и выдаёт произведение 
//чисел от M до N.

Console.Clear();

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int ProductOfNumbers(int a, int b)
{
    int pro = 1;

    for (int i = a; i <= b; i++)
    {
        pro = pro * i;
    }
    return pro;
}

Console.WriteLine(ProductOfNumbers(numberM, numberN));
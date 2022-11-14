Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = -number - 1;

while (a < number)
{
    a = a + 1;
    Console.Write($"{a} ");
}
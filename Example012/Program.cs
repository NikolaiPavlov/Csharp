Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(99 < number)
{
    if(number < 1000)
    {
        Console.WriteLine(number = number % 10);
    }
    else Console.WriteLine("Это не трехзначное число");
}
else Console.WriteLine("Это не трехзначное число");
// Вид 1

void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1();

// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method41(10, "z");
Console.WriteLine(res);

// Вид 4 через for

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string r = Method41(10, "z");
Console.WriteLine(r);


// Вывод таблицы умножения на экран

for (int k = 2; k <= 10; k++)
{
    for (int m = 2; m <= 10; m++)
    {
        Console.WriteLine($"{k} x {m} = {k * m}");
    }
    Console.WriteLine();
}
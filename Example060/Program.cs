//Задача 41
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.WriteLine("Задайте количество вводимых чисел:");
int m = Convert.ToInt32(Console.ReadLine());

bool CheckNumbers(int a)
{
    if(a > 0) return true;
    else return false;
}

int[] array = new int[m];

int count = 0;

for(int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите число {i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(CheckNumbers(array[i]) == true)
    {
        count++;
    }
}

Console.WriteLine($"Чисел больше нуля - {count}");
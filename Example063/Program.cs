//Задача 44: Не используя рекурсию, выведите первые N 
//чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Clear();

Console.WriteLine("Введите количество чисел Фибоначчи");
int n = Convert.ToInt32(Console.ReadLine());

int[] GetFibonacci(int size)
{
int[] result = new int[size];
result[0]=0;
result[1]=1;
for (int i=2;i<size;i++)
{
result[i] =result[i-1]+result[i-2];
}
return result;
}

Console.WriteLine($"Последовательность Фибоначчи: {string.Join(" ", GetFibonacci(n))}");
//int PrintFibonacci (int[] arr1)
//Console.Write($"{result} ");

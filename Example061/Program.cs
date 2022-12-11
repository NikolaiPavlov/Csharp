//Задача 42: Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное.

Console.Clear();

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DivideNumber(num));

string DivideNumber(int a)
{
    //int[] array = new int[]
    string b = String.Empty;
   
    while (a>0)
    {
        b=Convert.ToString(a%2)+b;
        a = a/2;
    }
return b;
}
Console.WriteLine(Convert.ToString(num,2));
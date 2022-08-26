// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Задайте значение M ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N ");
int n = int.Parse(Console.ReadLine());

void GetSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    GetSum(m, n - 1, sum);
}

GetSum(m, n, 0);
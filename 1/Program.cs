//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Задайте значение M ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N ");
int n = int.Parse(Console.ReadLine());

string Print(int max, int min)
{
    string s = "";
    if (max == min - 1) return s;
    return (Print(max - 1, min) + max).ToString();
}

Console.WriteLine(Print(n, m));
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//не получается, понятия не имею где ошибка
Console.WriteLine("Задайте значение M ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N ");
int n = int.Parse(Console.ReadLine());


int Akk(int m, int n)
{
    if (m == 0) return (n + 1);
    else if (m != 0 && n == 0) return Akk(m - 1, 1);
    else if (m > 0 && n > 0) return Akk(m - 1, Akk(m, n - 1));
    return Akk(m, n);
}



Console.WriteLine(Akk(m, n));
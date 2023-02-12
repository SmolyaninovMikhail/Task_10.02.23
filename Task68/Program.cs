// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"A(m,n) равна: {FuncAkkerman(m, n)}");

string f(int m, int n)
{
    if (m == n)
        return $"{m}";
    return f(m, n - 1) + $", {n}";
}

int FuncAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return FuncAkkerman(m - 1, 1);
    else
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}
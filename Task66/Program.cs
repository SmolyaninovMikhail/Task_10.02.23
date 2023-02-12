// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных элементов равна: {SumElements(m, n)}");

string f(int m, int n)
{
    if (m == n)
        return $"{m}";
    return f(m, n - 1) + $", {n}";
}

int SumElements(int m, int n)
{
    if (m == n)
        return n;
    return n + SumElements(m, n - 1);
}
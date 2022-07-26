// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N

void f(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (m++);
    f(m, n, sum);
}

Console.Write("Введите число 'M': ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'N': ");
int n = Convert.ToInt32(Console.ReadLine());
f(m, n, 0);

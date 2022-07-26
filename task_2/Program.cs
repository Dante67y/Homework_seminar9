// Напишите программу вычисления функции Аккермана с помощью рекурсии
// Даны два неотрицательных числа M и N

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
return Ackerman(m, n);
}
Console.Write("Введите число 'm': ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'n': ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Функция Аккермана равна: ");
Console.WriteLine(Ackerman(m, n));

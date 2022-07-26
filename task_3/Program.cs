int[,] CreateMatr(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
    return matrix;
}

void AvgMatr(int[,] matrix)
{
    Console.WriteLine();
    int max = 0, line = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (sum > max)
        {
            max = sum;
            line = i;
        }
    }
    Console.WriteLine("Лидер " + (line + 1) + " спортсмен, с максимальным результатом: " + max);
}
AvgMatr(CreateMatr(4, 4));

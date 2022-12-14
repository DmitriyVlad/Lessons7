// Задача 52 Вычисление среднеарифметического значения суммы каждого столбца массива

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write($"{matrix[i, j]}   ");
    }
    Console.WriteLine();
}
Console.WriteLine();

double[] sum = new double[4];
int m = 0;

while (m < matrix.GetLength(1))
{
    for (int n = 0; n < matrix.GetLength(0); n++)
    {
        sum[m] = sum[m] + matrix[n, m];
    }
    sum[m] = Math.Round(sum[m] / matrix.GetLength(0), 1);
    Console.Write($"{sum[m]}  ");
    m++;
}
Console.WriteLine();

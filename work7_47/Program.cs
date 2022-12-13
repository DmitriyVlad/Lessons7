// Задача 47 Создание двумерного массива, заполненного вещественными числами

double[,] matrix = new double[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double a = new Random().Next(-10, 10);
        double b = new Random().NextDouble();
        matrix[i, j] = Math.Round(a*b, 1);
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}

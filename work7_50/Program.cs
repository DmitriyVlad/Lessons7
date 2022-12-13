// Задача 50. Найти по заданной позиции элемента число или указать, что его нет

Console.Write("Введите позицию элемента по горизонтали: ");
string str = Console.ReadLine();
int n = Convert.ToInt32(str);
Console.Write("Введите позицию элемента по вертикали: ");
string str1 = Console.ReadLine();
int m = Convert.ToInt32(str1);

Console.WriteLine();
Console.WriteLine("Наша матрица:");

int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}

Console.WriteLine();

if (n >= 1 & n <= matrix.GetLength(1) & m >=1 & m <= matrix.GetLength(0)) 

    Console.WriteLine("На данной позиции (по горизонтали - " + n + " и по вертикали - "
                      + m + " находится число: " + matrix[m-1, n-1]);

else 

    Console.WriteLine("В массиве такое число отсутствует");

// Задайте двумерный массив размером MxN,
// заполненный случайными вещественными числами

Console.Clear();

Console.Clear();
Console.WriteLine("Введите размерность массива:");
Console.Write("Количество строк ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов  ");
int M = Convert.ToInt32(Console.ReadLine());

double [,] MyMatrix = new double[N, M];

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() + new Random().Next(1,11);
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

InputMatrix(MyMatrix);
PrintMatrix(MyMatrix);
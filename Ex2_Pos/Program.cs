// На вход приянть позицию элемента в двумерном массиве,
// и вернуть значение этого элемента или указать,
// что такого элемента нет.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
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

int PosMatrix(int[,] matrix, int xPos, int yPos)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == xPos && j == yPos)
                result = matrix[i, j];
        }

    }
    return result;
}

Console.WriteLine("Введите размерность массива:");
Console.Write("Количество строк ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов  ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] MyMatrix = new int[N, M];
InputMatrix(MyMatrix);
PrintMatrix(MyMatrix);

Console.WriteLine("Введите позицию числа:");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());


if (PosMatrix(MyMatrix, n, m) == 0)
    Console.WriteLine("Pадана неправильная позиция числа в массиве");
else
    Console.WriteLine($"Число на позиции ({n}, {m}): {PosMatrix(MyMatrix, m, n)}");
// Задать двумерный массив из целых чисел.
// Найти среднее арифметическое элементов в каждом столбце.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        };
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность массива:");
Console.Write("Количество строк ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов  ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] MyMatrix = new int[N, M];
InputMatrix(MyMatrix);
PrintMatrix(MyMatrix);

void AverageMatrix (int [,] matrix, int n)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            float result = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[j,i];
        }    
        Console.Write($"{result/n}   "); 
    }
}

AverageMatrix(MyMatrix, N);
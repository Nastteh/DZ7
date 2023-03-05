//Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

double[] GetArithmeticMeanOfColumns(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    double sum=0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
              
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }

        result[j] = Math.Round(sum / matrix.GetLength(0), 1, MidpointRounding.ToZero);
    }
    return result;
}

Console.Write("Введите количество строк M:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N:");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = CreateMatrixRndInt(rows, columns, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"{string.Join("; ", GetArithmeticMeanOfColumns(matrix))}.");
// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

bool CheckIndexValidity(int i, int j, int[,] matrix)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1)) return true;
    else return false;
}

int ExtractingIndexFromMatrix(int num1, int num2, int[,] matrix)
{
    int number = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == num1 && j == num2) number = matrix[i, j];
        }
    }
    return number;
}

Console.WriteLine("Индекс строки необходимого числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Индекс столца необходимого числа:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);

if (CheckIndexValidity(num1, num2, matrix))
 Console.WriteLine($" Число в ячейке с индексами i = {num1}, j = {num2} -> {ExtractingIndexFromMatrix(num1, num2, matrix)}");
else Console.WriteLine(" Числа с такими индексами в нашем массиве нет");

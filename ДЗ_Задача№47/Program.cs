// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами от -10,0 до 10,0.

// m = 3, n = 4.

void PrintArray(double[,] matr)
{
    for ( int i = 0; i < matr.GetLength(0); i++)
    {   
        for ( int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for ( int i = 0; i < matr.GetLength(0); i++)
    {
        for ( int j = 0; j < matr.GetLength(1); j++)
        {
            double number = new Random().Next(-10,10) + new Random().NextDouble();
            matr[i, j] =  Math.Round(number, 1);
        }
    }
}

double[,] matrix = new double [3, 4];
FillArray(matrix);
PrintArray(matrix);


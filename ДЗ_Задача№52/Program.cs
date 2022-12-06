// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

double sumAverage1 = 0;
double value1 = 0;
double sumAverage2 = 0;
double value2 = 0;
double sumAverage3 = 0;
double value3 = 0;
double sumAverage4 = 0;
double value4 = 0;

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}
PrintArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == 0)
        {
            sumAverage1 += array[i, j];
            value1++;
        }
        if (j == 1)
        {
            sumAverage2 += array[i, j];
            value2++;
        }
        if (j == 2)
        {
            sumAverage3 += array[i, j];
            value3++;
        }
        if (j == 3)
        {
            sumAverage4 += array[i, j];
            value4++;
        }
    }
}
sumAverage1 = sumAverage1 / value1;
sumAverage2 = sumAverage2 / value2;
sumAverage3 = sumAverage3 / value3;
sumAverage4 = sumAverage4 / value4;
Console.Write($"Average:{sumAverage1}, {sumAverage2}, {sumAverage3}, {sumAverage4}");    
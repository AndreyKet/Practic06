// Задача 50. Напишите программу, которая на вход принимает число,
// и возвращает индексы числа в двумерном массиве или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Write("Введите число: ");
int serchValue = int.Parse(Console.ReadLine());
int[,] array = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
Console.WriteLine();

void Sercher(int[,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            if (serchValue == array[i, j])
            Console.WriteLine($"Число {serchValue} на позиции [{i},{j}]");
        }
        
    }
}

bool isInArray = false;

for ( int i = 0; i < array.GetLength(0); i++)
{
    for ( int j = 0; j < array.GetLength(1); j++)
    {
        if (serchValue == array[i, j])
        {
            isInArray = true;
            break;
        }
        
    }
}
if (isInArray)
{
    Sercher(array);
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}



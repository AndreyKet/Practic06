// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// int[,] FillArray(int[,] array)
// {
//     for ( int i = 0; i < array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for ( int i = 0; i < array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// int[,] array = new int[3, 4];
// array = FillArray(array);
// PrintArray(array);

// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4



// void FillArray(int[,] array)
// {
//     for ( int i = 0; i < array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < array.GetLength(1); j++)
//         {
//             if ((i % 2 != 0) && (j  % 2 != 0))
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for ( int i = 0; i < array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// int[,] array = new int[3, 4]
// {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2 ,4},
// };
// PrintArray(array);
// FillArray(array);
// Console.WriteLine();
// PrintArray(array);
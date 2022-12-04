// string[,] table = new string [2, 5];
// // table[0,0]  table[0,1] table[0,2] table[0,3]...
// // table[1,0]
// // table[2,0]...

// table[1,2] = "word";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"--{table[rows, columns]}--");
//     }
// }

// void PrintArray(int[,] matr)
// {
//     for ( int i = 0; i < matr.GetLength(0); i++)
//     {   
//         for ( int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for ( int i = 0; i < matr.GetLength(0); i++)
//     {
//         for ( int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1,10);
//         }
//     }
// }

// int [,] matrix = new int [3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// int [,] pic = new int [,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
// {0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0},
// {0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0},
// {0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0},
// {0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0},
// {0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0},
// {0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0},
// {0, 0, 0, 1, 0, 0, 1, 0 ,0, 1, 0, 1, 0, 1, 0},
// {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
// {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
// {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0},
// {0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
// {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
// };


// void PrintImage(int[,] image)
// {
//     for ( int i = 0; i < image.GetLength(0); i++)
//     {   
//         for ( int j = 0; j < image.GetLength(1); j++)
//         {
//             // Console.Write($"{image[i, j]} ");
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//     Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(10, 10);
// PrintImage(pic);


// // Факториал

// double Factorial (int n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// // Console.WriteLine(Factorial(5));
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// // Fibonachi

// int Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }


// Семинар 06: Одномерне массивы продолжение.


// Циклы:
// Прерывание - break

// Console.WriteLine("Начало цикла");
// for (int i = 0; i < 10; i++)
// {
//     if (i == 2)
//     {
//         Console.WriteLine($"{i} это уже и так много");
//         break; // прерывание цикла и выход из него
//     }
//     Console.WriteLine(i);
// }
// Console.WriteLine("Конец цикла");

// Переход к следущей итерации - continue
// Console.WriteLine("Начало цикла");
// for (int i = 0; i < 4; i++)
// {
//     if (i == 2)
//     {
//         Console.WriteLine($"Мне не нравится квадрат {i}");
//         continue;
//     }
//     Console.WriteLine(i * i);
// }
// Console.WriteLine("Конец цикла");

// Двумерные массивы:
// определение
// int[,] arr = new int[2,3] // [количество строк, количество столбцов]
// {
//     {1, 2, 3}, // [количество одномерных массивов, длина каждого одномерного массива]
//     {2, 3, 4}
// };
// // или
// int[,] arr = 
// {
//     {1, 2, 3},
//     {2, 3, 4}
// };
// // или
// int[,] arr = new int[2,3];

// Получение длин массива:
// количество элементов (всего)
// int[,] arr = new int[2,3] // [количество строк, количество столбцов]
// {
//     {1, 2, 3},
//     {2, 3, 4}
// };
// int arrayLength = arr.Length;
// Console.Write(arrayLength); // 6

// количество строк
// int linesCount = arr.GetLength(0);
// Console.Write(linesCount); // 2

// количество столбцов
// int columnsCount = arr.GetLength(1);
// Console.Write(columnsCount); // 3

// Заполнение двумерного массива:
// int[,] arr = new int[2, 3];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(0, 10);
//     }
// }

// // Вывод двумерного массива
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine(arr[0, 0]);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = new double[5];
// for (int i = 0; i < array.Length; i++)
// {
//     double number = new Random().Next(0, 10) + new Random().NextDouble(); // 8 + 0.22 = 8.22
//     array[i] =  Math.Round(number, 2); // округление числа: Math.Round(число для округления, количество знаков)
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// // При таком варианте мы никогда не ошибёмся с диапазоном массива, потому что первое число массива
// // есть в массиве, а остальные либо меньше, либо больше, либо равны ему
// double min = array[0];
// double max = array[0];

// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// bool IsNumberInArray(int number, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] array = new int[8];
// array = FillArray(array);
// PrintArray(array);
// Console.WriteLine("\n Введите число: ");
// int number = int.Parse(Console.ReadLine());
// // bool isNumberInArray = IsNumberInArray(number, array);
// bool isInArray = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == number)
//     {
//         isInArray = true;
//         break;
//     }
// }
// // Все операции сравнения и равенства - bool
// // 5 > 8 -- тоже bool
// if (isInArray)
// {
//     Console.WriteLine($"Число {number} есть в массиве");
// }
// else
// {
//     Console.WriteLine($"Числа {number} нет в массиве");
// }





// Работа со строками
// int a = 5;
// int b = 8;

// // Конкатенация - слепление двух строк: делается с помощью символа +
// Console.WriteLine("Первое число: " + a + ". Второе число: " + b);

// // Интерполяция - встраивать переменные в строку: делает с помощью $ в начале строки
// // и переменные обрамляются фигурными скобками {}
// Console.WriteLine($"Первое число: {a}. Второе число: {b}");


// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int[] arr = new int[8];
// int[] reverseArr = new int[8];

// FillArray(arr);
// PrintArray(arr);

// for (int i = 0; i < arr.Length; i++)
// {
//     reverseArr[arr.Length - 1 - i] = arr[i];
// }
// Console.WriteLine();
// PrintArray(reverseArr);

// // int[] ReverseArray(int[] array)
// // {
// //     for (int i = 0; i < array.Length / 2; i++)
// //     {
// //         int reverse = array[i];
// //         array[i] = array[array.Length - 1 - i];
// //         array[array.Length - 1 - i] = reverse;
// //     }
// //     return array;

// // }

// // Console.Write("Введите длинну массива: ");
// // int[] array = new int[int.Parse(Console.ReadLine())];

// // FillArray(array);
// // PrintArray(array);

// // ReverseArray(array);
// // Console.WriteLine();
// // PrintArray(array);


// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерно массиве. 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10
// [1, -5, 8, 4, -9] -> 4.33

// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }


// Console.Write("Введите длинну массива: ");
// int[] array = new int[int.Parse(Console.ReadLine())];

// FillArray(array);
// PrintArray(array);

// int count = 0;
// double srednearifmet = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         srednearifmet += array[i];
//         count++;
//     }
//     srednearifmet = srednearifmet / count;
// }

// Console.WriteLine();
// Console.WriteLine(count);
// Console.Write(srednearifmet);

// Задча 3. Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12





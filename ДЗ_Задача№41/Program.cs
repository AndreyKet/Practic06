// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000,1001);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}


Console.Write("Введите колличество чисел в массиве: ");
int[] array = new int[int.Parse(Console.ReadLine())];
int positiveValue = 0;
array = FillArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positiveValue++;
    }
}

PrintArray(array);
Console.WriteLine($"В массиве чисел больше нуля: {positiveValue}");



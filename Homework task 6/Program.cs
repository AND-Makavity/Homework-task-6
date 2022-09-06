/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.Write($"Введите количество числел: ");
int.TryParse(Console.ReadLine(), out int M);

int[] array = new int[M];

void FillArray(int[] _array, int min, int max)
{
    for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().Next(min, max);
        Console.Write($"{_array[i]}, ");
    }
    Console.WriteLine();
}

void FindQtyPozitive(int[] _array)
{
    int qty = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i] > 0) qty++;
    }
    Console.WriteLine($"Количество положительных элементов в массиве равно: {qty}");
}

FillArray(array, -9, 10);
FindQtyPozitive(array);

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int k1 = 5, b1 = 2, k2 = 9, b2 = 4;
float x, y;
if (k1 != k2)
{
    x = (float)(b2 - b1) / (k1 - k2);
    y = (float)k1 * x + b1;
    Console.WriteLine($"Точка пересечения х: {x}, y: {y}");
}
else Console.WriteLine($"Данные прямые не пересекаются");
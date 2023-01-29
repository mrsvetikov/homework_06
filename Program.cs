// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество чисел: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[M];

// void InputNum(int m)
// {
//     for (int i = 0; i < m; i++)
//     {
//         Console.Write($"Введите {i + 1} число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// int AboveZero(int[] array) 
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count = count + 1;
//     }
//     return count;
// }

// InputNum(M);

// Console.WriteLine($"Количество чисел больше 0: {AboveZero(array)} ");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

void FindXY(double k1, double k2, double b1, double b2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"две прямые пересекутся в точке ({x};{y})");
}

FindXY(k1, k2, b1, b2);















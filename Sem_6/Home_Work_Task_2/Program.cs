// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x1 = 0;
double x2 = 0;
double y1 = k1 * x1 + b1;
double y2 = k2 * x2 + b2;


if (y1 == y2)
{
    Console.WriteLine(" прямые лежат друг на друге");
 
}
else if ((k1 / k2) == 1)
{
    Console.WriteLine(" прямые  паралельны");
}
else 
{
    Console.WriteLine(" прямые  не паралельны");
}

if (x1 == x2)
{
    x1 = (b1 - b2) / (k2 - k1);
    y1 = k1 * ((b1 - b2) / (k2 - k1)) + b1;
    Console.WriteLine($"({x1} , {y1})");
}

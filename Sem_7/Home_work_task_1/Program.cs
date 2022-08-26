// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Console.WriteLine("Введите значения m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n");
int numberN = Convert.ToInt32(Console.ReadLine());


double[,] arrayNumberMAndN = new double[numberM, numberN];
for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
    {
        arrayNumberMAndN[i, j] = (new Random().Next(-100,100)/10.0);//  можно так но диаазон только от 0 до 1 arrayNumberMAndN[i, j] = Math.Round(new Random().NextDouble(),2);
        Console.Write(arrayNumberMAndN[i, j] + " | ");
    }
    Console.WriteLine();
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите значения m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("==========");


int[,] arrayNumberMAndN = new int[numberM, numberN];

for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
    {
        arrayNumberMAndN[i, j] = new Random().Next(1, 10);
        Console.Write(arrayNumberMAndN[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("==========");
string colummNumber = string.Empty;

for (int i = 0; i < arrayNumberMAndN.GetLength(1); i++)
{
    double summ = 0;
    double Columm = 0;
    for (int j = 0; j < arrayNumberMAndN.GetLength(0); j++)
    {
        summ += arrayNumberMAndN[j, i];
    }
    Columm = Math.Round(summ / arrayNumberMAndN.GetLength(0), 2);
    colummNumber += $": {Columm} ";
}


Console.WriteLine($" Средне арифметическое каждого толбца  {colummNumber} .");








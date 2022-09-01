/**
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка**/

Console.WriteLine("Введите значения m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n");
int numberN = Convert.ToInt32(Console.ReadLine());

int[,] ArrayMatrix(int numberM, int numberN)
{
    int[,] arrayNumberMAndN = new int[numberM, numberN];
    for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
        {
            arrayNumberMAndN[i, j] = new Random().Next(1, 10);
        }
    }
    return arrayNumberMAndN;
}

void PrintArrayMatrix(int[,] arrayNumberMAndN)
{
    for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
        {
            Console.Write(arrayNumberMAndN[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = ArrayMatrix(numberM, numberN);

Console.Write("\n");

PrintArrayMatrix(matrix);

Console.Write("\n");

int[] ArraySumm(int[,] matrix)
{
    int[] arrauSumm = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arrauSumm[i] += matrix[i, j];

        }
    }
    return arrauSumm;
}
int[] arraySummLine = ArraySumm(matrix);

Console.WriteLine(string.Join(" , ", arraySummLine));

int LineSummMinVaLues(int[] arraySummLine)
{
    int number = 1;
    int min = arraySummLine[0];
    for (int i = 0; i < arraySummLine.Length; i++)
    {
        if (min > arraySummLine[i])
        {
            min = arraySummLine[i];
            number = (i + 1);
        }
    }
    return number;
}
Console.Write("\n");

Console.WriteLine("Минимальная сумма элементов строке под номером " + LineSummMinVaLues(arraySummLine));
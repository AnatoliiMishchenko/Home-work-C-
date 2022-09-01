/**
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2**/
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

int[,] OrderArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int t = j + 1; t < matrix.GetLength(1); t++)
            {
                if (matrix[i, j] < matrix[i, t])
                {
                    int max = matrix[i, j];
                    matrix[i, j] = matrix[i, t];
                    matrix[i, t] = max;
                }
            }
        }
    }
    return matrix;
}

PrintArrayMatrix(OrderArray(matrix));
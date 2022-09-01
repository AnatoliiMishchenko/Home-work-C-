// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
            arrayNumberMAndN[i, j] = new Random().Next(0, 10);
        }
    }
    return arrayNumberMAndN;
}

void PrintArrayMatrix(int[,] arrayNumberMAndN)
{
    if (arrayNumberMAndN != null)
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
    else
    {
        Console.WriteLine("Введенная матрица не крадратная , преобразование не возможно");
    }

}
int[,] matrix = ArrayMatrix(numberM, numberN);

PrintArrayMatrix(matrix);

Console.WriteLine("\n");

int[,] TrasporArrayMatrix(int[,] matrix)
{
    if (numberM == numberN)
    {
        int[,] transportArrayMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                transportArrayMatrix[j, i] = matrix[i, j];
            }
        }
        return transportArrayMatrix;
    }
    else
    {
        return null;
    }
}

PrintArrayMatrix(TrasporArrayMatrix(matrix));




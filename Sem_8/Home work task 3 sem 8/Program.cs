/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
Console.WriteLine("Введите значения m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения m1");
int numberM1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n1");
int numberN1 = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (numberM != numberM1)
    {
        Console.Write("Не совпадают размерности матриц");
        break;
    }
    else
    {

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

        int[,] matrix1 = ArrayMatrix(numberM, numberN);
        int[,] matrix2 = ArrayMatrix(numberM1, numberN1);

        Console.Write("\n");

        PrintArrayMatrix(matrix1);

        Console.Write("\n");

        PrintArrayMatrix(matrix2);





        int[,] ArrayMultiplicationMatrix1OnMatrix2(int[,] matrix1, int[,] matrix2)
        {
            int[,] arrayMultiplication = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)

                {
                    arrayMultiplication[i, j] = 0;
                    for (int t = 0; t < matrix1.GetLength(1); t++)
                    {
                        arrayMultiplication[i, j] += matrix1[i, t] * matrix2[t, j];
                    }
                }
            }
            return arrayMultiplication;
        }

        int[,] arrayMultiplication = ArrayMultiplicationMatrix1OnMatrix2(matrix1, matrix2);

        Console.Write("\n");

        PrintArrayMatrix(arrayMultiplication);
        break;
    }
}


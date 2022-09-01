/**Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6**/

/* 
GПОЧЕМУТО НЕ СЧИТАЕ ЕСЛИ  СОВПАДЕНИЙ БОЛЬШЕ*/

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




int MinNumber(int[,] matrix)//Нахождение минимального элемента матрицы
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
            }

        }
    }
    return min;
}

int min = MinNumber(matrix);


int MinNumberCount(int[,] matrix, int min)//Нахождение количество повторении минимального элемента в матрице
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (min == matrix[i, j])
            {
                count++;
            }
        }
    }
    return count;
}

int countMinRepead = MinNumberCount(matrix, min);

int[,] CoordinatesMin = new int[countMinRepead, 2];


int[,] MinNumberPosition(int[,] matrix, int[,] CoordinatesMin, int min)// Нахождение координат мин элемнта в матрице
{
    int listMin = 0;
    int columnMin = 0;
    int f = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min == matrix[i, j])
            {
                listMin = i;
                columnMin = j;

                for (; f < CoordinatesMin.GetLength(0);)
                {
                    for (int r = 0; r < 2; r++)
                    {
                        CoordinatesMin[f, r] = listMin;
                        listMin = columnMin;

                    }

                    break;
                }
                f++;
            }
        }
    }

    return CoordinatesMin;
}

int[,] coordinatesMin = MinNumberPosition(matrix, CoordinatesMin, min);

int[,] deleteMatroix = new int[matrix.GetLength(0) - countMinRepead, matrix.GetLength(0) - countMinRepead];

int[,] DeleteMatrix(int[,] matrix, int[,] coordinatesMin, int[,] deleteMatroix)
{
    int k = 0;
    int l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)// проход по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// проход по столбцам
        {
            for (int r = 0; r < coordinatesMin.GetLength(0); r++)// проход по строкам матрицы координат
            {
                if (CoordinatesMin[r, 0] != i && CoordinatesMin[r, 1] != j)
                {
                    deleteMatroix[k, l] = matrix[i, j];
                    l++;
                }
            }
        }
        l = 0;
        for (int r = 0; r < coordinatesMin.GetLength(0); r++)
        {
               if (coordinatesMin[r, 0] != i)
                {
                    k++;
                }     
        }
    }
    return deleteMatroix;
}


Console.WriteLine(min);

Console.WriteLine(countMinRepead);
Console.WriteLine();

PrintArrayMatrix(coordinatesMin);

Console.WriteLine();
int [,] delet =DeleteMatrix(matrix,coordinatesMin,deleteMatroix);

PrintArrayMatrix(delet);




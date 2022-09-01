/*Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/

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

string NumberRepetition(int[,] matrix)
{
    int count = 0;
    string numberRepetition = string.Empty;
    for (int t = 0; t < 10; t++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (t == matrix[i, j])
                {
                    count++;
                }
            }
        }
        if (count != 0)
        {
            if (count % 10 == 6 || count % 10 == 1 || count % 10 == 5 || count % 10 == 8 || count % 10 == 9 || count % 10 == 7 || count % 10 == 6
            || count == 13 || count == 14 || count == 10 || count == 12)
            {
                numberRepetition += $"{t} встречается {count} раз \n";
            }
            else
            {
                numberRepetition += $"{t} встречается {count} раза \n";
            }
        }
        count = 0;
    }
    return numberRepetition;
}

Console.Write(NumberRepetition(matrix));

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
Console.WriteLine("Введите значения m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n");
int numberN = Convert.ToInt32(Console.ReadLine());


    int[,] arrayNumberMAndN = new int[numberM, numberN];
    for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
        {
            arrayNumberMAndN[i, j] = i + j;
            Console.Write(arrayNumberMAndN[i,j] + " ");
             }
        Console.WriteLine();
    }
    

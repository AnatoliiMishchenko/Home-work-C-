// Задача 51:Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
Console.WriteLine("Введите значения m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n");
int numberN = Convert.ToInt32(Console.ReadLine());
int summNumberDiagonal = 0;
string numberDiagonal = string.Empty;


int[,] arrayNumberMAndN = new int[numberM, numberN];
for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
    {
        arrayNumberMAndN[i, j] = new Random().Next(1, 10);
        if (i == j)
        {
            summNumberDiagonal += arrayNumberMAndN[i, i];
            numberDiagonal += arrayNumberMAndN[i, i] + " ";
        }
        Console.Write(arrayNumberMAndN[i, j] + " ");
    }
    Console.WriteLine();
    
}
Console.WriteLine("++++++++++++");
Console.WriteLine( " сумма элементов  " + numberDiagonal + " = " + summNumberDiagonal);



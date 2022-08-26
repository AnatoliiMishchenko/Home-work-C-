// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.WriteLine("Введите значения m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n");
int numberN = Convert.ToInt32(Console.ReadLine());


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
Console.WriteLine("**********");

for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
    {
        if (j % 2 == 0 && i % 2 == 0)
        {
            arrayNumberMAndN[i, j] = arrayNumberMAndN[i, j] * arrayNumberMAndN[i, j];
        }
        Console.Write(arrayNumberMAndN[i, j] + " ");
    }
    Console.WriteLine();
}












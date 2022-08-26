// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Введите значения m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения I, не забудте что индексы в матрице начинаются с 0");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило J, не забудте что индексы в матрице начинаются с 0");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int[,] arrayNumberMAndN = new int[numberM, numberN];

for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)// заполение массива 
{
    for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
    {
        arrayNumberMAndN[i, j] = new Random().Next(1, 10);
        Console.Write(arrayNumberMAndN[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

string ElementSearch(int number, int[,] arrayNumberMAndN)//метод поиска числа в массиве
{ string elementSearch = string.Empty;
    int t = 0;
    for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
        {
            if (arrayNumberMAndN[i, j] == number)
            {
                t++;
            }
        }
        elementSearch = (t > 0) ? $"числа {number} в массиве есть" : $"числа {number} в массиве нет";
    }
    return elementSearch;
}

string ElementMass(int numberOne, int numberTwo, int[,] arrayNumberMAndN)//метод поиска числа по  индексам массива
{
    string elementMass = string.Empty;
    for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
        {
            if (numberOne >= 0 && numberOne < arrayNumberMAndN.GetLength(0) && numberTwo < arrayNumberMAndN.GetLength(1) && numberTwo >= 0)
            {
                elementMass = $"элемент с индексами [{numberOne}, {numberTwo}] = " + Convert.ToString(arrayNumberMAndN[numberOne, numberTwo]);
            }
            else
            {
                elementMass = $"элемента с индексами [{numberOne}, {numberTwo}] в массиве нет";
            }
        }
    }
    return elementMass;
}

Console.WriteLine("===========");
Console.WriteLine(ElementSearch(number, arrayNumberMAndN));

Console.WriteLine("===========");
Console.WriteLine(ElementMass(numberOne, numberTwo, arrayNumberMAndN));
// Задача 29: Напишите программу, которая задаёт массив из N  элементов и задается диапозон родомных чисел выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите число элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения диапазана рондомных чисел");
int minA = Convert.ToInt32(Console.ReadLine());
int maxA = Convert.ToInt32(Console.ReadLine());


int[] ArrayRandom(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

Console.WriteLine("[" + string.Join(" , ", ArrayRandom(number, minA, maxA)) + "]");


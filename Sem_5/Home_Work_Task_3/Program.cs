// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите количество элемментов массива");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ДИАПАЗОН СЛУЧАЙНЫХ ЧИСЕЛ");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());

int[] arrayRandom(int number, int start, int end)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

int summaOddNumber(int[] array)
{
    int summaOdd = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summaOdd += array[i];

    }
    return summaOdd;
}
int [] arrayRandom1 =arrayRandom(number,start,end);
Console.WriteLine("{" + String.Join(" . ", arrayRandom1) + "}");
Console.WriteLine("Сумма нечетных элементов массива : " + summaOddNumber(arrayRandom1)); 

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите число элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;



int[] arr = new int[number];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine("[" + string.Join(" , ", arr) + "]");
Console.WriteLine("Количество четных элементов массива " + count);

//  Вариант решения задачи через функции( rfr z gj)
int[] arrayRandom(int numberI)
{
    int[] arrayR = new int[numberI];
    for (int i = 0; i < arrayR.Length; i++)
    {
        arrayR[i] = new Random().Next(100, 1000);
    }
    return arrayR;
}

int evenNumber(int[] arr)
{
    int c = 0; // счетчик четных элементов
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            c++;           
        }
    }
    return c;
}
int [] arrt = arrayRandom(number);
Console.WriteLine("[ " + String.Join(" , ", arrt) + "]");
Console.WriteLine("Количество четных элементов массива " + evenNumber(arrt));// 

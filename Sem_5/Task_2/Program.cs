// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("Введите количество элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапозон заполнения массива от А до Б");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число  которое хотите найти в массиве");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int n = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(start, end);
}
Console.WriteLine("[" + string.Join(" , ", array) + "]");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == count)
    {
        n++;
    }
}


if (n > 0)
{
    Console.WriteLine(" Да имеется");
}
else
{
    Console.WriteLine("Нет не имеется");

}

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];

}
Console.WriteLine("[" + string.Join(" , ", array) + "]");


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
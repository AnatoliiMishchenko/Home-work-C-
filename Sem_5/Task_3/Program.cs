// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.WriteLine("Введите количество элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапозон заполнения массива от А до Б");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(start, end);
}
Console.WriteLine("{" + string.Join(" : ", array) + "}");
//count = array.Length / 2 + array.Length % 2;
if (array.Length % 2 == 0)
{
    count = array.Length / 2;
}
else
{
    count = array.Length / 2 + 1;
}

int[] arraySumm = new int[count];

for (int i = 0; i < (array.Length / 2); i++)
{
    arraySumm[i] = array[i] * array[array.Length - i - 1];
}
if (array.Length % 2 > 0)
{
    arraySumm[arraySumm.Length - 1] = array[array.Length / 2];
}
Console.WriteLine("[" + string.Join(" , ", arraySumm) + "]");

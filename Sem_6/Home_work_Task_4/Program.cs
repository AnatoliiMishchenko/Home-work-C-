// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.WriteLine("Введите количество элементов массива");
int count = Convert.ToInt32(Console.ReadLine());

int[] arrayOne(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

int[] arrayCopi(int[] array)
{
    

    int[] arrayCopi = new int[count];


    for (int j = 0; j < arrayCopi.Length; j++)
    {
        
        arrayCopi[j] = array[array.Length - 1 -j];
      }


    return arrayCopi;
}
int[] arrayT = arrayOne(count);
Console.WriteLine(string.Join(" , ", arrayT));
Console.WriteLine(string.Join(" , ", arrayCopi(arrayT)));

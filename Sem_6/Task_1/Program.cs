Console.WriteLine("Введите чилос элементов массива");
int count = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальный элементов ");
int start1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечный элементов массива");
int end1 = Convert.ToInt32(Console.ReadLine());



int[] array(int count, int start, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void ReversArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }

}


int[] arr = array(count, start1, end1);

Console.WriteLine("[" + (string.Join(" , ", arr)) + "]");
ReversArray(arr);
Console.WriteLine("[" + (string.Join(" , ", arr)) + "]");


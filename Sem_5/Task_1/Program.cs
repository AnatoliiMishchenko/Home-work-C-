Console.WriteLine("Введите чилос элементов массива");
int count = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[count];
//  int summP = 0;
// int summO = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     if (array[i] > 0)
//     {
//         summP += array[i];
//     }
//     else
//     {
//         summO += array[i];
//     }
// }
// Console.WriteLine(string.Join(" , ", array));
// Console.WriteLine(" Сумма положительных числе равбна : " + summP + "\n Cумма отрицательных числел равьна : " + summO);

int[] array(int count, int start, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void summOtrPol(int[] array, out int summP, out int summO)
{
    summO = 0;
    summP = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            summP += array[i];
        }
        else
        {
            summO += array[i];
        }
    }
}
int[] arr = array(count, -9, 10);
summOtrPol(arr, out int summP, out int summO);
Console.WriteLine("[" + (string.Join(" , ", arr)) + "]");
Console.WriteLine($" Сумма положительных числе равбна : {summP} \n Cумма отрицательных числел равьна : {summO}");
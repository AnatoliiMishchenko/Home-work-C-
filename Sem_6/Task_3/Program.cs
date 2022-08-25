// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
//string count = string.Empty;
// while (number != 0)
// {
//     count += Convert.ToString(number % 2);
//     number = number / 2;
// }
// char[] rtd = count.ToCharArray();
// char[] Revers(char[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         char tenp = ' ';
//         tenp = arr[i];
//         arr[i] = arr[arr.Length - i - 1];
//         arr[arr.Length - i - 1] = tenp;
//     }
//     return arr;
// }
// Console.WriteLine(string.Join("", Revers(rtd)));
void printBinary(int number)
{
    if (number <= 0)
    {
      return;
   // Console.Write(number % 2);
    }
    printBinary(number / 2);
    
    Console.Write(number % 2);
}
printBinary(number);


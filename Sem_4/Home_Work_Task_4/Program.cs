// Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
// {2, 3, 4} -> 2, 6, 24
// {5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1
Console.WriteLine("Введите число элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон рандомных чисел");
int minR = Convert.ToInt32(Console.ReadLine());
int maxR = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int[] arramul = new int[number];
int mul = 1;

for (int i = 0; i < array.Length; i++)
{
    //Console.WriteLine("Введите значение элемента массива");// можно задавать массив в ручную
    //int n = Convert.ToInt32(Console.ReadLine());//
    //array[i] = n;//
    array[i] = new Random().Next(minR, maxR);

    for (int j = 1; j <= array[i]; j++)
    {
        mul *= j;
        arramul[i] = mul;
    }
    mul = 1;

}
Console.WriteLine(string.Join(" , ", array));
Console.WriteLine(string.Join(" , ", arramul));



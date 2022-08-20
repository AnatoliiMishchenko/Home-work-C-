//Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("Введите количество элементов массива вещетсвенных чисел ");
int number = Convert.ToInt32(Console.ReadLine());
double[] array = new double[number];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(" Введите значения элемента массива " + i);
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("{" + String.Join(" | ", array) + "}");
double maxNumber = array[0];
double minNumner = array[1];

for (int i = 0; i < array.Length; i++)
{
    if (maxNumber <= array[i])
    {
        maxNumber = array[i];
    }
    if (minNumner >= array[i])
    {
        minNumner = array[i];
    }
}

double difference =maxNumber - minNumner;
Console.WriteLine($"Разница между {maxNumber} И {minNumner} равна = {difference}");

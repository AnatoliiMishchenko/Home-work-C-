//  Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


Console.WriteLine("ВВЕДИТЕ ДИАПАЗОН СЛУЧАЙНЫХ ЧИСЕЛ");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());


int [] array = new int[123];

int [] arrayRandom( int start , int end){
    for( int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(start,end);
    }
    return array;
}
int number ( int [] arr){
    int count = 0;
    for(int i = 0 ; i < arr.Length ; i++){
    if(arr[i] >= 10 && arr[i] <= 99){
        count++;
    }
    }
   return count;

}
 int [] arrayr = arrayRandom(start,end);
 Console.WriteLine("{" + string.Join(" , " , arrayr) + "}");
 Console.WriteLine(" Количество чилесл лежащих в диапазоне от 10 до 99 составляет " + number(arrayr));

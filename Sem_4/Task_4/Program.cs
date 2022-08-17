// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.WriteLine("Ввеедите число элементов массива");
int f = Convert.ToInt32(Console.ReadLine());


int[] arrayRandom( int N){
int [] arrya = new int [N];

for(int i = 0; i < arrya.Length; i++){
    arrya[i] = new Random().Next(0,2);
}
return arrya;
}


Console.WriteLine(string.Join(" , ",arrayRandom(f)));


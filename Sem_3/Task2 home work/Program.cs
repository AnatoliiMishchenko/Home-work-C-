
Console.WriteLine("Введите координаты первой точки X И Y и Z");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ввежите координаты второй точки X и Y и Z");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
double longAB = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));// решение в координатах
Console.WriteLine(longAB);




double [] arrayA = new double[3];
double [] arrayB = new double[3];

Console.WriteLine("Введите координаты первой точки А");
arrayA[0] = Convert.ToDouble(Console.ReadLine());
arrayA[1] = Convert.ToDouble(Console.ReadLine());
arrayA[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки В");
arrayB[0] = Convert.ToDouble(Console.ReadLine());
arrayB[1] = Convert.ToDouble(Console.ReadLine());
arrayB[2] = Convert.ToDouble(Console.ReadLine());

double lonAB = Math.Sqrt(Math.Pow(arrayB[0] - arrayA[0],2) + 
Math.Pow(arrayB[1]-arrayA[1],2) + Math.Pow(arrayB[2] - arrayA[2],2));// решение в массиве
Console.WriteLine(lonAB);



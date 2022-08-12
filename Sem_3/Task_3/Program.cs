
Console.WriteLine("Введите координаты первой точки X И Y");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ввежите координаты второй точки X и Y");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double [] arrayA = new double[2];
double [] arrayB = new double[2];

Console.WriteLine("Введите координаты первой точки А");
arrayA[0] = Convert.ToDouble(Console.ReadLine());
arrayA[1] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки В");
arrayB[0] = Convert.ToDouble(Console.ReadLine());
arrayB[1] = Convert.ToDouble(Console.ReadLine());

double lonAB = Math.Sqrt(Math.Pow(arrayB[0] - arrayA[0],2) + Math.Pow(arrayB[1]-arrayA[1],2));
Console.WriteLine(lonAB);

double longAB = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2-y1,2));
Console.WriteLine(longAB);
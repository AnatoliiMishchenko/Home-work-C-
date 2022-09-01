Console.WriteLine("Введите значения m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения n");
int numberN = Convert.ToInt32(Console.ReadLine());

int[,] ArrayMatrix(int numberM, int numberN)
{
    int[,] arrayNumberMAndN = new int[numberM, numberN];
    for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
        {
            arrayNumberMAndN[i, j] = new Random().Next(0, 10);
        }
    }
    return arrayNumberMAndN;
}

void PrintArrayMatrix(int[,] arrayNumberMAndN)
{
    for (int i = 0; i < arrayNumberMAndN.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumberMAndN.GetLength(1); j++)
        {
            Console.Write(arrayNumberMAndN[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = ArrayMatrix(numberM, numberN);

PrintArrayMatrix(matrix);

int [,] ArrayCopy( int [,] matrix){
for (int j = 0; j < matrix.GetLength(1); j++)
{
    int nuberCopy = matrix[0, j];
    matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
    matrix[matrix.GetLength(0) - 1, j] = nuberCopy;
}
return matrix;
}


Console.WriteLine("\n");
PrintArrayMatrix(ArrayCopy(matrix));








// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int DataEntry(string str)
{
    System.Console.Write("введите " + str + " = ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] FillArray(int rows, int columns)
{
    double[,] arr = new double[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1); // от -10 до 10
        }
    }
    return arr;
}

void ShowArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
int m = DataEntry("количество строк");
int n = DataEntry("количество столбцов");
double[,] array = FillArray(m, n);
ShowArray(array);


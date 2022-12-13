// Задача 52. Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int DataEntry(string str)
{
    System.Console.Write("введите " + str + " = ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] FillArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rand.Next(10);
        }
    }
    return arr;
}

void ShowArray(int[,] arr)
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

void ColumnsArithmeticMean(int[,] arr)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double result = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            result += arr[i, j];
        }
        
        result = Math.Round(result/arr.GetLength(0), 1);
        System.Console.Write(result + "; ");
    }

}

Console.Clear();
int m = DataEntry("количество строк");
int n = DataEntry("количество столбцов");
int[,] array = FillArray(m, n);
ShowArray(array);
ColumnsArithmeticMean(array);
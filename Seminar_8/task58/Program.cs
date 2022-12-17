// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int DataEntry(string str)
{
    Console.Write("введите " + str + " = ");
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
            arr[i, j] = rand.Next(0, 10);
        }
    }
    return arr;
}

void ShowArray(string str, int[,] arr)
{
    Console.WriteLine(str);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixsMultiply(int[,] arrFirst, int[,] arrSecond)
{
    int[,] resultMatrix = new int[arrFirst.GetLength(0), arrSecond.GetLength(1)];
    for (int i = 0; i < arrFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arrSecond.GetLength(1); j++)
        {
            for (int k = 0; k < arrFirst.GetLength(1); k++)
            {
                resultMatrix[i,j] += arrFirst[i, k] * arrSecond[k, j];
            }
        }
    }
    return resultMatrix;
}

Console.Clear();
int m = DataEntry("количество строк первой матрицы");
int n = DataEntry("количество столбцов первой матрицы");

int[,] arrayFirst = FillArray(m, n);
int[,] arraySecond = FillArray(n, m);

ShowArray("первая матрица ", arrayFirst);
ShowArray("вторая матрица ", arraySecond);

int[,] result = MatrixsMultiply(arrayFirst, arraySecond);
ShowArray("результирующая матрица ", result);

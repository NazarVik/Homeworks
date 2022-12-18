// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] FillArray(int n)
{
    int[,] arr = new int[n, n];
    int count = 1;

    for (int i = 0; i <= n/2; i++)
    {
        for (int j = i; j < n - i; j++)
            arr[i, j] = count++;
        for (int j = i + 1; j < n - i; j++)
            arr[j, n - 1 - i] = count++;
        for (int j = n - 2 - i; j >= i; j--)
            arr[n - 1 -i, j] = count++;
        for (int j = n - 2 - i; j >= 1 + i; j--)
            arr[j, i] = count++;
    }

    return arr;
}

void ShowArray(int[,] arr)
{
    Console.WriteLine();
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

Console.Clear();
int n = DataEntry("задайте размер квадратной матрицы = ");
int[,] resultArray = FillArray(n);
ShowArray(resultArray);
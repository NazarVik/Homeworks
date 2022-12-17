// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
        for (int j = 0; j < columns; j++)
            arr[i, j] = rand.Next(0, 10);
    return arr;
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {    
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "  ");
        Console.WriteLine();
    }    
}

void SortArray (int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(1) - 1 - j; k++)
            {
                if(arr[i, k] < arr[i, k +1 ])
                {
                    temp = arr[i,k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }  
}

Console.Clear();
int m = DataEntry("количество строк");
int n = DataEntry("количество столбцов");
int[,] array = FillArray(m, n);
ShowArray(array);
SortArray(array);
Console.WriteLine();
ShowArray(array);
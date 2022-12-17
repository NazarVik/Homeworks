// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

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
            arr[i, j] = rand.Next(0, 10);
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


int FindMinRow(int[,] arr)
{
    int minSum = 0;
    int minRow = 0;
    int sum;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        minSum += arr[0,j];
    }

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }

        if(sum < minSum) 
        {
            minSum = sum;
            minRow = i;
        } 
    }
    return minRow + 1;
}

Console.Clear();
int m = DataEntry("количество строк");
int n = DataEntry("количество столбцов");
int[,] array = FillArray(m, n);
ShowArray(array);
int minRow = FindMinRow(array);
Console.WriteLine();
Console.WriteLine(minRow + " строка имеет наименьшую сумму элементов");
Console.WriteLine();

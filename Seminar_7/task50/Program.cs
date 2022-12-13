// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            arr[i, j] = rand.Next(100);
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

bool SearchNumber(int[,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                System.Console.WriteLine($"позиция искомого элемента - [{i},{j}]");
                return true;
            }
        }
    }
    System.Console.WriteLine("искомого элемента в массиве на найдено");
    return false;
}

Console.Clear();
int m = DataEntry("количество строк");
int n = DataEntry("количество столбцов");
int[,] array = FillArray(m, n);
ShowArray(array);
int searchNum = DataEntry("искомое число в диапозоне от 0 до 100");
SearchNumber(array, searchNum);


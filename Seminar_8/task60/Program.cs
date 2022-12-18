// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого 
// элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int NewRandom(int[,,] arr)
{
    Random rand = new Random();
    int randomNumber = rand.Next(50, 100);

    foreach (int item in arr)
    {
        if (randomNumber == item) randomNumber = rand.Next(10,50);
    }
    return randomNumber;
}

int[,,] FillArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                
                arr[i, j, k] = NewRandom(arr);
            }
        }
    }
    return arr;
}

void ShowArray(int[,,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
int x = DataEntry("введите размерность трехмерной матрицы x = ");
int y = DataEntry("введите размерность трехмерной матрицы y = ");
int z = DataEntry("введите размерность трехмерной матрицы z = ");
int[,,] matrix = new int[x, y, z];
matrix = FillArray(matrix);
ShowArray(matrix);
System.Console.WriteLine();


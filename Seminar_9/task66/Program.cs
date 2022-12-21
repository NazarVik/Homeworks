// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int CalculateSum(int leftNum, int rightNum)
{
    if (leftNum == rightNum) return leftNum;
    return CalculateSum(leftNum, rightNum - 1) + rightNum;
}

Console.Clear();
int leftRangeNumber = DataEntry("введите натуральное число m = ");
int rightRangeNumber = DataEntry("введите натуральное число n = ");
int resultSum  = CalculateSum(leftRangeNumber, rightRangeNumber);
Console.WriteLine($"сумму натуральных элементов в промежутке от {leftRangeNumber} до {rightRangeNumber} = {resultSum}");


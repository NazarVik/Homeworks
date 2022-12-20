// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void ShowNumbers(int num)
{
    if (num == 1) 
    {
        Console.WriteLine(num);
        return;
    }
    Console.Write(num + ", ");
    ShowNumbers(num - 1);
    return;
}

Console.Clear();
int number = DataEntry("введите натуральное число = ");
ShowNumbers(number);
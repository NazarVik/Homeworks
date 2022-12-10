// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
// 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] DataEntry() 
{
    System.Console.Write("введите числa = ");
    string[] arr = Console.ReadLine().Split(",");
    return arr;
}
// 
Console.Clear();
string[] array = DataEntry();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(int.Parse(array[i]) > 0)
    {
        count++;
    }
}

System.Console.WriteLine(String.Join(", ", array) + " -> " + count); 
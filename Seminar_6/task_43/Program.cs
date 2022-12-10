// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double DataEntry(string str) {
    System.Console.Write("введите " + str + " = ");
    double num = double.Parse(Console.ReadLine());
    return num;
}

Console.Clear();
double b1 = DataEntry("b1");
double k1 = DataEntry("k1");
double b2 = DataEntry("b2");
double k2 = DataEntry("k2");

double pointOfIntersectionX = (b2 - b1)/(k1 - k2);
double pointOfIntersectionY = k1 * pointOfIntersectionX + b1;
System.Console.WriteLine($"({pointOfIntersectionX} ; {pointOfIntersectionY})");



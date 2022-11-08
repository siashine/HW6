// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());



double[] coordinates = LineCrossCoordinates(k1, k2, b2, b1);
Console.WriteLine();
Console.WriteLine($"Координаты пересечения заданных прямых: ({coordinates[0]},{coordinates[1]})");

double[] LineCrossCoordinates(double k1, double k2, double b2, double b1)
{
  double[] coor = new double[2];
  coor[0] = (b2 - b1) / (k1 - k2);
  coor[1] = (b1 * k2 - b2 * k1) / (k2 - k1);
  return coor;
}

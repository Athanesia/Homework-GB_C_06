// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите k1");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
float b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2");
float k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
float b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.WriteLine("Графики лежат на 1 линии");
else if (k1 == k2) Console.WriteLine("Графики параллельны");
else
{
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;
    Console.WriteLine($"X:{x} Y:{y}");
}
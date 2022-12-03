// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

// AB = √(xb - xa)2 + (yb - ya)2
// Pow(Double, Double)	Возвращает указанное число, возведенное в указанную степень.
// Sqrt(Double)	Возвращает квадратный корень из указанного числа.
// Math.Round(distance, 2) округляет

Console.Write("Введите размер N-мерного пространства: ");
int space = Convert.ToInt32(Console.ReadLine());
if (space < 2) Console.Write("Вводите целое положительное число больше 1");
else
{
    try
    {
        int[] Array1 = new int[space];
        int[] Array2 = new int[space];
        for (int i = 0; i < Array1.Length; i++)
        {
            Console.Write($"Введите координату под индексом {i} первой точки: ");
            Array1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < Array2.Length; i++)
        {
            Console.Write($"Введите координату под индексом {i} второй точки: ");
            Array2[i] = Convert.ToInt32(Console.ReadLine());
        }
        double Sum = 0;
        for (int i = 0, j = 0; i < Array1.Length && j < Array2.Length; i++, j++)
        {
            Sum = Sum + (Math.Pow(Array2[j] - Array1[i], 2));
        }
        double distance = Math.Sqrt(Sum);
        Console.WriteLine(Math.Round(distance, 2));
    }
    catch
    {
        Console.WriteLine("Вводите только целые числа");
    }
}

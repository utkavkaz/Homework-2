// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Pow(Double, Double)	
// Возвращает указанное число, возведенное в указанную степень.

void Cube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        double result = Math.Pow(i, 3);
        Console.Write($"{result} ");
    }
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1) Console.Write("Введите положительное число");
else Console.Write("Таблица кубов: ");
Cube(N);





// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.Write("Таблица кубов: ");

// for (int i = 1; i <= N; i++)
// {
//     double cube = Math.Pow(i, 3);
//     Console.Write($"{cube} ");
// }







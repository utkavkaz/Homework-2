// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Pal(int num)
{
    string res;
    if (num < 10000 || num > 99999) res = "Вы вели не пятизначное число";
    else
    {
        int num1 = num % 10;
        int num2 = (num / 10) % 10;
        int num3 = (num / 100) % 10;
        int num4 = (num / 1000) % 10;
        int num5 = num / 10000;

        if (num1 == num5 && num2 == num4) res = "Число является палиндромом";
        else res = "Число не является палиндромом";
    }
    return res;
}
try
{
    Console.Write("Введите пятизначное число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Pal(x));
}
catch
{
    Console.WriteLine("Надо было вводить именно пятизначное число!");
}

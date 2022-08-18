/*
Задача 23
Напишите программу, которая принимает на вход число (N) и
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// Вариант 1:

Console.WriteLine("Построю таблицу кубов от 1 до числа N. Введите ваше любимое число N:");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;
Console.WriteLine($"Таблица кубов для числа {number}:");
while (n <= number)
{
    double result = Math.Pow(n, 3);
    Console.Write(result + "\t");
    n++;
}
Console.WriteLine();

// Вариант 2:
/*
Console.WriteLine("Построю таблицу кубов от 1 до числа N. Введите ваше любимое число N:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов для числа {number}:");
for (int start = 1; start <= number; start++)
{
Console.Write(Math.Pow(start,3) + "\t");
}
Console.WriteLine();
*/
/*
Домашняя задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int len;
len = number.Length;
if (len > 5) Console.WriteLine("Внимание! В числе больше 5 цифр");
else if (number[0] == number[4] && number[1]==number[3])
Console.WriteLine("Введенное число является палиндромом");
else
Console.WriteLine("Введенное число НЕ является палиндромом");

﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Эта программа на вход принимает число и выдаёт, является ли число чётным.");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Да, число четное: {number} % 2 = 0");
}
else
{
    Console.WriteLine($"Нет, число не четное: {number} % 2 = 1");
}

﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Vvedite trehznachnoe chislo : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a < 1000)
{
    int b = (a / 10);
    int c = b % 10;
    Console.WriteLine(c);
}
else
{
    Console.WriteLine($"{a} ne trehznachnoe chislo");
}
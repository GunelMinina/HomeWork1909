// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Vvedite chislo : ");
string a = Console.ReadLine();

if (int.Parse(a) < 100)
{
    Console.WriteLine("Tret'ey tsifry net");
}
else
{
    Console.WriteLine($"Tret'ya tsifra {a[2]}");
}
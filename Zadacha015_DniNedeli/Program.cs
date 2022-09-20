Console.WriteLine("Vvedite chislo, oboznachaushee den nedeli : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
{
    Console.WriteLine($"{a} vichodnoy den'");
}
else if (a >= 1 && a <= 5)
{
    Console.WriteLine($"{a} budniy den'");
}
else
{
    Console.WriteLine("nekorrektnoe chislo");
}
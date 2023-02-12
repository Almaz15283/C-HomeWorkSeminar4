Console.Clear();
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c )
{
    Console.WriteLine($"Число 1 {a} самое большое");
    return;
}
if (b > a && b > c )
{
    Console.WriteLine($"Число 2 {b} самое большое");
    return;
}
if (c > a && c > b )
{
    Console.WriteLine($"Число 3 {c} самое большое");
    return;
}
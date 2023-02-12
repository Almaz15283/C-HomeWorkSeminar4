// 
Console.Clear();
Console.Write("введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine());
if (a == 6 || a == 7)
{
    Console.WriteLine("ДА! выходной");
}
else 
{
    Console.WriteLine("НЕТ! Будний день");
}
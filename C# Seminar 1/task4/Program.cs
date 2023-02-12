Console.Clear();
Console.Write("Введите число N :");
int N = int.Parse(Console.ReadLine());
int i = 0;
while( i < N )
{
    Console.Write($"{i}");
    i = i+2;
}
return;

Console.Clear();
Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine());
if (a > b) Console.WriteLine($" Число {a} > {b}");
    else Console.WriteLine($" Число {b} > {a}");
return;

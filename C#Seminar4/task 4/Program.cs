Console.Clear();
Console.Write("Введите длинну массива N ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
Console.Write(Array(array));
Console.Write(Output(array));
Console.WriteLine("  Введите элемент массива который необходимо вывести на экран ");
int el = int.Parse(Console.ReadLine());
Console.Write(El(array));
Console.WriteLine("  Введите число на которое заменить все элементы массива до знака R ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("  Введите знак R ") ;
int r = int.Parse(Console.ReadLine());
Console.Write(Change(array, x, r));
Console.Write(Output(array));
Console.Write("  Введите число на которое надо изменить массив ");
int x1 = int.Parse(Console.ReadLine());
Console.Write(ChangePlus(array, x1, n));
Console.Write(Output(array));
Console.Write(Min(array));






int[] Array(int[] array)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = (int)new Random().Next(1, 30);
    }
    return array;
}
int[] Output(int[] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    return array;
}

int El(int[] array)
{
    int f = array[el -1];
    Console.WriteLine($"элемент массива = {array[el - 1]} ");
    return f;
}


int[] Change(int[] array, int x, int r)
{
    for (int i = 0; i < r; i++)
    {
        array[i] = x;
    }
    return array;
}

int[] ChangePlus(int[] array, int x1, int n)
{
    for (int i = 0; i < n-1; i++)
    {
        array[i] = array[i] + x1;
    }
    return array;
}
int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < n; i++)
    {
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine(min);
    return min;
}
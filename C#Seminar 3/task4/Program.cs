// Удалите из массива повторяющиеся элементы, решение так себе потому что не оставляет изначальный массив в том виде в котором завел пользователь. 
Console.Clear();
int n = new Random().Next(1, 50);
int[] array = new int[n];
List<int> array1 = new List<int>();
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 10);
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < (n - 1 - i); j++)
    {
        if (array[j] > array[j + 1])
        {
            int R = array[j];
            array[j] = array[j + 1];
            array[j + 1] = R;
        }
    }
}
/*for (int i = 0; i < n; i++)
    Console.Write($"{array[i]}, ");*/ // проверка на сортировку

for (int i = 0; i < n - 1; i++)
{
    if (array[i] != array[i + 1])
    {
        array1.Add(array[i]);
    }
}
array1.Add(array[n-1]);
for (int i = 0; i < array1.Count; i++)
    Console.Write($"{array1[i]} ;");
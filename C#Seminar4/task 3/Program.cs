using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int[] array = new int[8];
        int[] Array(int[] array)
        {
            for (int i =0; i<8;i++)
            {
                array[i] = new Random().Next(1,100);
                Console.Write($"{array[i]}; ");
            }
            return array;
        }
        Console.Write(Array(array));
    }
}
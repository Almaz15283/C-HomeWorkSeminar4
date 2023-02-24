using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите число A: ");
        int a = int.Parse(Console.ReadLine());
        int Summ(int a)
        {
            int one = a/100;
            int three = a%10;
            int two = a%100/10;
            int summ = one+two+three;
            return summ;
        }
      Console.WriteLine(Summ(a));
    }
}
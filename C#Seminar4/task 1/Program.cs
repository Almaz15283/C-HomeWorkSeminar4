// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int b = int.Parse(Console.ReadLine());
int result = a;
int Deegre(int a,int b)
{
    for (int i = 1; i < b; i++)
       {
              result = result*a;
       }
    return result;
}
Console.Write(Deegre(a,b));
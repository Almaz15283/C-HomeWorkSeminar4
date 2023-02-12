//  Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает,
// что третьей цифры нет.
Console.Clear();
Console.Write("Enter your number :");
int a = int.Parse(Console.ReadLine());
if (a<100 || a>999) 
{   
    Console.WriteLine("Enter correct number!");
    return;
}
    else
    {
        int a1 = a%10;
        Console.WriteLine($"number = {a1}");
    }
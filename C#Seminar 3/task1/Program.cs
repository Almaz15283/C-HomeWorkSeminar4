// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
/*int a1 = a/10000;
int a2 = a%10;
int a3 = a/1000%10;
int a4 = a%100/10;
Console.WriteLine(a1);
Console.WriteLine(a2);
Console.WriteLine(a3);
Console.WriteLine(a4);
Console.WriteLine(a);*/
if (a > 10000 && a < 100000){
if (a/10000 == a%10 && a/1000%10 == a%100/10)
    Console.WriteLine("Число А полиндром");
    else Console.WriteLine("Число А НЕ полиндром");
}
else Console.Write("Введите пятичначное число");


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
int [] A = new int[3];
int [] B = new int [3];
double distans = 0;
for (int i= 0; i < 3; i++)
{
    A[i] = new Random().Next(-100,100);
    B[i] = new Random().Next(-100,100);
    Console.WriteLine($" A {A[i]}; B {B[i]}");
}
distans = Math.Sqrt((Math.Pow((A[0] - B[0]),2) + Math.Pow((A[1] - B[1]), 2) + Math.Pow((A[2] - B[2]), 2)));
Console.WriteLine($"Расстояние между точками = {Math.Round(distans, 3)}");

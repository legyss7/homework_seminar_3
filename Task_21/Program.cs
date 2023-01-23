/* Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


Console.WriteLine("Введите координаты точки А: ");
Console.Write("X: ");
int aX = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Y: ");
int aY = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Z: ");
int aZ = int.Parse(Console.ReadLine() ?? " ");

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int bX = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Y: ");
int bY = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Z: ");
int bZ = int.Parse(Console.ReadLine() ?? " ");

double r = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2) + Math.Pow(aZ - bZ, 2));

Console.WriteLine("Расстояние между точками {0:#.00}", r);

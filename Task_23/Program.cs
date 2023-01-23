/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число N: ");
int n;
while (int.TryParse(Console.ReadLine(), out n) != true)
    Console.WriteLine("Веденный символ не число! Введите число N: ");

bool inv = false;
if (n < 0)
{
    n = Math.Abs(n);
    inv = true; 
}
else inv = false;

Console.WriteLine("Таблица кубов чисел от 1 до N");
for (int i = 1; i <= n; i++)
{
    if(inv) Console.Write(-Math.Pow(i, 3) + ", ");
    else    Console.Write(Math.Pow(i, 3) + ", ");
}
Console.WriteLine("\b\b ");
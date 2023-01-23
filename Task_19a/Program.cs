/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом. 
14212 -> нет
12821 -> да
23432 -> да */

//Ввод пятизначного числа
int EnterFiveDigitNumber()
{
    int number = 0;
    bool inv = false;
    while (number < 9999 || number > 99999)
    {
        Console.WriteLine("Введите пятизначное число:");
        while (int.TryParse(Console.ReadLine(), out number) != true)
        {
            Console.Write("Введенный символ не является числом! ");
            Console.WriteLine("Введите пятизначное число:");
        }
        if (number < 0)
        {
            number = Math.Abs(number);
            inv = true;
        }
        else inv = false;
    }
    if (inv) number *= -1;
    return number;
}

// Палиндром числа
string Palindrome(int num)
{
    string str = $"Число {num} является палиндромом.";
    int count = 0;
    int number = Math.Abs(num);
    //посчитаем сколько цифр в числе num
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    //Запишем цифры числа num в массив numArray
    int[] numArray = new int[count];
    number = Math.Abs(num);
    for (int i = 0; i < numArray.Length; i++)
    {
        numArray[numArray.Length - 1 - i] = number % 10;
        number /= 10;
    }
    //
    for (int i = 0; i < numArray.Length / 2; i++)
    {
        if (numArray[i] != numArray[numArray.Length - 1 - i])
        {
            str = $"Число {num} не является палиндромом.";
            break;
        }
    }
    return str;
}

int number = EnterFiveDigitNumber();
Console.WriteLine(Palindrome(number));







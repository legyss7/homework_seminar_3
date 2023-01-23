/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом. 
14212 -> нет
12821 -> да
23432 -> да */
// Решить задачу с применением string

//Ввод пятизначного положительного числа
string EnterFiveDigitNumber()
{
    string numbers = "0123456789";
    string numbers0 = "123456789";
    string str = String.Empty;
link:
    while (str.Length != 5)
    {
        Console.WriteLine("Введите пятизначное число:");
        str = (Console.ReadLine() ?? String.Empty);
        // Проверка на положительные числа
        if (str[0] == '-')
        {
            Console.WriteLine("Программа работает только с положительными числами.");
            Console.WriteLine("====================================");
            str = String.Empty;
            goto link;
        }
        // Проверяем являются ли введенные символы числом
        for (int i = 0; i < str.Length; i++)
        {
            if (numbers.Contains(str[i])) { }
            else
            {
                Console.WriteLine("Введенный символ не является числом.");
                Console.WriteLine("====================================");
                str = String.Empty;
                goto link;
            }
        }
        // Проверяем является ли первый символ числом большим нуля 
        if (!numbers0.Contains(str[0]))
        {
            str = String.Empty;
            goto link;
        }
    }

    return str;
}
// Палиндром числа
string Palindrome(string num)
{
    string str = "Число " + num + " является палиндромом.";
    for (int i = 0; i < num.Length / 2; i++)
    {
        if (num[i] != num[num.Length - 1 - i])
        {
            str = "Число " + num + " не является палиндромом.";
            break;
        }
    }
    return str;
}

Console.WriteLine(Palindrome(EnterFiveDigitNumber()));
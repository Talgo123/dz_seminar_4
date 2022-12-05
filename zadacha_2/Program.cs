// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

int EntryNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int ProductNumber(int number)
{
    int result = 0;
    int ostatok = 0;
    for (int i = 0; number > 0; i++)
    {
        ostatok = number % 10;
        number = number / 10;
        result = result + ostatok;
    }
    return result;
}

int digit = EntryNumber("Введите число: ");
int result = ProductNumber(digit);
Console.WriteLine($"Сумма цифр числа {digit} равна {result}");

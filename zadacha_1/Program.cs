//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// // 2, 4 -> 16

Console.Clear();

int EntryNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int DegreeNumber(int numberA, int numberB)
{
    int product = 1;
    for (int i = 1; i <= numberB; i++)
    {
        product = product * numberA;
    }
    return product;
    
}

int numberA = EntryNumber("Введите число А: ");
int numberB = EntryNumber("Введите число В: ");
int result = DegreeNumber(numberA, numberB);
Console.WriteLine(result);
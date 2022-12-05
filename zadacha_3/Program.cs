Console.Clear();

int[] RandomDigit(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 99);
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int i;
    Console.WriteLine("Массив размером 8: ");
    for (i = 0; i < count; i++)
    {
        Console.Write(col[i] + " ");
    }
}
int[] massiv = new int[8];
RandomDigit(massiv);
PrintArray(massiv);

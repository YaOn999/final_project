string[] NewMassive(int size)
{
    string[] stringArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}

Console.Write("Веедите размер массива: ");
int size = int.Parse(Console.ReadLine());
string[] stringArray = NewMassive(size);
Console.WriteLine($"введенный массив [{String.Join(", ", stringArray)}]");



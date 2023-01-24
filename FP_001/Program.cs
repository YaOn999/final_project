string[] NewArray(string[] stringArray, int sizeNewArray)
{
    string[] newArray = new string[sizeNewArray];
    int temp = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newArray[temp] = stringArray[i];
            temp++;
        }
    }
    return newArray;
}

int NewArraySize(string[] stringArray)
{
    int size = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3) size++;
    }
    return size;
}

string[] NewMassive(int size)
{
    string[] stringArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
    Console.WriteLine($"введенный массив [{String.Join(", ", stringArray)}]");
    return stringArray;
}

Console.Write("Веедите размер массива: ");
int size = int.Parse(Console.ReadLine());

string[] stringArray = NewMassive(size);
int sizeNewArray = NewArraySize(stringArray);

string[] newArray = NewArray(stringArray, sizeNewArray);
Console.WriteLine($"новый массив [{String.Join(", ", newArray)}]");



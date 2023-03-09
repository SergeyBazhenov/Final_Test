Console.WriteLine("Программа формирующая из имеющегося массива строк, массив строк длина которых меньше либо равна 3 символа.");

Console.WriteLine();
Console.Write("Введите количество элементов исходного массива: ");
uint size;
while (!uint.TryParse(Console.ReadLine()!, out size))
{
    Console.WriteLine("Неверный ввод! Необходимо ввести положительное число.");
    Console.Write("Введите количество элементов исходного массива: ");
}

string?[] array = GetArray(size);
Console.WriteLine();
Console.Write("Полученный массив: ");
PrintArray(array);
Console.WriteLine();

int secondArrayLength = GetSecondArrayLength(array);

string?[] secondArray = GetSecondArray(array);
Console.WriteLine();
Console.Write("Новый массив: ");
PrintArray(secondArray);

string?[] GetArray(uint size)
{
    Console.WriteLine("Введите элементы массива:");
    string?[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string?[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.Write("]");
}

int GetSecondArrayLength(string?[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!.Length <= 3) count++;
    }
    return count;
}

string?[] GetSecondArray(string?[] array)
{
    string?[] secondArray = new string?[secondArrayLength];
    int indexOfSecondArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!.Length <= 3)
        {
            secondArray[indexOfSecondArray] = array[i];
            indexOfSecondArray++;
        }
    }
    return secondArray;
}

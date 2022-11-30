string[] GetArray()
{
    Console.WriteLine("Введите элементы массива через запятую");
    Console.WriteLine();
    string? str = Console.ReadLine();
    string[] array = str.Split(',');
    return array;
}
string[] FormingNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[size] = array[i];
            size++;
        }
    }
    return newArray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
string[] array = GetArray();
Console.WriteLine();
string[] newArray = FormingNewArray(array);
PrintArray(newArray);

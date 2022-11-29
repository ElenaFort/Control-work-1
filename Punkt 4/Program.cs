Console.WriteLine("Введите элементы массива через запятую");
Console.WriteLine();
string str = Console.ReadLine();
string[] array = str.Split(',');
var newArray = new string[array.Length];
var size = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[size] = array[i];
        size++;
    }
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
Console.WriteLine();
PrintArray(newArray);

void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("введите элементы для вывода: ");
        array[i] = Console.ReadLine();
    }
    Console.Write($"[{string.Join(", ", array)}]");
    Console.WriteLine("");
}

Console.Clear();
Console.Write("введите колчитсво элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
InputArray(array);

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

void ReleaseArray(string[] array)
{
    string[] massiv = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            massiv[count] = array[i];
            count++;
        }
    }
    Console.Write($"[{string.Join(", ", massiv)}]");
    
}
Console.Clear();
Console.Write("введите колчитсво элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
InputArray(array);
ReleaseArray(array);
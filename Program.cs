string[] GetArray(string text)
{
    System.Console.WriteLine(text);
    string[] array = Console.ReadLine()!.Split();
    return array;
}


void PrintArray(string[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void SizeNewArray(string[] mass, out int size)
{
    size = mass.Length;
    for (int j = 0; j < mass.Length; j++)
    {
        if (mass[j].Length > 3)
        {
            size--;
        }
    }
}



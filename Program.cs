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


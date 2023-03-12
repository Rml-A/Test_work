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

string[] NewArray(string[] mass, int size)
{

    string[] newArray = new string[size];
    int k = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            newArray[k] = mass[i];
            k++;
        }

    }
    return newArray;
}

string[] arr = GetArray("Заполните массив: ");
PrintArray(arr);
System.Console.WriteLine();

SizeNewArray(arr, out int size);
string[] newArr = NewArray(arr, size);
PrintArray(newArr);

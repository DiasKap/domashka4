int[] Array(int size)
{
    int[] result = new int[size];
    for (int a = 0; a < size; a++)
    {
        result[a] = new Random().Next(100);
    }
    return result;
}

int size = 18;
Console.WriteLine($"[{String.Join(" | ", Array(size))}]");
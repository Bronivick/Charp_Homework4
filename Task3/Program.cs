int[] array = new int[8];
GetArray;

void GetArray();
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 500);
        Console.Write(array[i] + " ");
    }
}

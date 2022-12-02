int[] array = { 16, 2, 34, 84, 35, 16, 77, 84, 91, 101 };
int n = array.Length;
int find = 84;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}
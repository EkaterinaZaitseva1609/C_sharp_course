int[] array = { 1, 8, 2, 3, 4, 5, 7, 16, 8 };

int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
        index++;
}
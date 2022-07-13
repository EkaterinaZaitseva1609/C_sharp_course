// Практикум


string Print(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        output += (array[i] + " ");
    }
    return output;
}


string[] GetWord(string[] array, int n)
{
    string[] outputArray = new string[array.Length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            outputArray[index] = array[i];
            index++;
        }
    }
    return outputArray;
}


System.Console.WriteLine("Введит число N");
int n = int.Parse(Console.ReadLine());

string[] array = { "hello", "123", "world", "Denmark", "yes", "min" };
string[] result = GetWord(array, n);
string output = Print(result);
System.Console.WriteLine(output);
File.WriteAllText("output.txt", output);


/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
*/
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }

}
/*
Print(mass);
*/

// function (random)
void GetRandom(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }
    }
}
/*int[,] mass = new int[4, 4];
GetRandom(mass);
*/

int[,] mass = new int[4, 4];
GetRandom(mass);

Print(mass);

foreach (int elem in mass)
{
    int counter = 0;
   
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass [i, j] == elem) counter++;
        
        }
        
    }
System.Console.WriteLine(elem + " встречается " + counter + "раз");
}

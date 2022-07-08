/* Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
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
            mass[i, j] = new Random().Next(1, 10);
        }
    }
}
/*int[,] mass = new int[3, 4];
GetRandom(mass);
*/


int[,] mass = new int[4, 4];
GetRandom(mass);

Print(mass);

int min = mass[0, 0];
int iMin = 0;
int jMin = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] < min)
        {
            min = mass[i, j];
            iMin = i;
            jMin = j;
        }


    }

}
System.Console.WriteLine();
System.Console.WriteLine(min + " " + iMin + " " + jMin);
System.Console.WriteLine();



for (int i = 0; i < mass.GetLength(0); i++)
{
    if (i == iMin)
    {
        continue;
    }
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (j == jMin)
        {

            continue;
        }
System.Console.Write(mass[i,j] + " ");
    }
System.Console.WriteLine();
}

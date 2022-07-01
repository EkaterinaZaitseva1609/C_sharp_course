/*Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
*/
// function (вывод)
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



// function (замена строк массива) !

void ChengeMas(int[,] mass)
{
    int x = 0;
for (int j = 0; j < mass.GetLength(1); j++)
{
    // System.Console.Write(mass[(mass.GetLength(0) -1), j] + " ");

    x = mass[0, j];
    mass[0, j] = mass[(mass.GetLength(0) - 1), j];
    mass[(mass.GetLength(0) - 1), j] = x;

}
} 
/*
int[,] mass = new int[4, 4];
ChengeMas(mass);
Print(mass);
*/



/*
int m = 4, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }
    }

Print(mass);
System.Console.WriteLine();

int x = 0;
for (int j = 0; j < mass.GetLength(1); j++)
{
    x = mass[0, j];
    mass[0, j] = mass[n-1, j];
    mass[n-1, j] = x;
}
Print(mass);

*/
/*
int[,] mass = new int[4, 4];
GetRandom(mass);

Print(mass);
System.Console.WriteLine();

int x = 0;
for (int j = 0; j < mass.GetLength(1); j++)
{
    // System.Console.Write(mass[(mass.GetLength(0) -1), j] + " ");

    x = mass[0, j];
    mass[0, j] = mass[(mass.GetLength(0) - 1), j];
    mass[(mass.GetLength(0) - 1), j] = x;

}

Print(mass);

*/


int[,] mass = new int[4, 4];
GetRandom(mass);

Print(mass);
System.Console.WriteLine();

ChengeMas(mass);
Print(mass);
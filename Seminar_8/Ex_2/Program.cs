/*
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
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

/*
int[,] mass = new int[4, 4];
GetRandom(mass);
Print(mass);

System.Console.WriteLine();

if(mass.GetLength(1) != mass.GetLength(0))
{
System.Console.WriteLine("ошибка");
}
for (int i = 0; i < mass.GetLength(1); i++)
{
for (int j = 0; j < mass.GetLength(0); j++)
{
System.Console.Write(mass[j, i] + " ");
}
System.Console.WriteLine();
}
*/

int[,] mass = new int[4, 4];
GetRandom(mass);
Print(mass);

System.Console.WriteLine();
if(mass.GetLength(1) != mass.GetLength(0))
{
System.Console.WriteLine("ошибка");
}
int x = 0;
for (int i = 0; i < mass.GetLength(1); i++)
{
for (int j = i; j < mass.GetLength(1); j++)
{
x = mass[i, j];
mass[i, j] = mass[j, i];
mass[j, i] = x;
}
}
Print(mass);
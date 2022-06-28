/*
Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
*/
/*
int m = 3, n = 4;
double[,] mass = new double[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10) + new Random().NextDouble();
    }
}
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
       System.Console.Write( Math.Round (mass[i, j], 2) + " ");
    }
    System.Console.WriteLine();
}
*/
/*
Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
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
int m = 5, n = 6;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

System.Console.WriteLine("Укажите позицию элемента X ");
int x = Int32.Parse(Console.ReadLine());

System.Console.WriteLine("Укажите позицию элемента Y ");
int y = Int32.Parse(Console.ReadLine());
if (x >= m || y >= n)
{
    System.Console.WriteLine("такого элемента нет");
}
else
{
System.Console.WriteLine("значение элемента " + mass[x, y]);
System.Console.WriteLine();
}
Print(mass);
*/

/*
Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
*/

int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 5);
    }
}
Print(mass);
for (int i = 0; i < mass.GetLength(1); i++)
{
    double summ = 0;
    for (int j = 0; j < mass.GetLength(0); j++)
    {
        summ += mass[j, i];

    }
    summ = summ / mass.GetLength(0);
    System.Console.WriteLine(Math.Round(summ, 2));
}

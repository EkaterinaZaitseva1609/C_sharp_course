/*
Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int m = 3, n = 4;
int[,] array = new int[n, m];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 5);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(array[i, j] + " ");

    }
    System.Console.WriteLine();
}
int summ = 0;
int minSize = Math.Min(array.GetLength(0), array.GetLength(1));
for (int i = 0; i < minSize; i++)
{
        summ += array[i, i];
}
System.Console.Write(" Сумма элементов главной диагонали: "+ summ);
System.Console.WriteLine();


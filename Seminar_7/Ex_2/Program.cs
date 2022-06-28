/*
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/ 

int m = 3, n = 4;
int[,] array = new int [n, m];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         
         array[i, j] = i + j;
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

/* Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
*/

// function (print mass)
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


/*
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
System.Console.WriteLine("минимальное значение " + min + ", значение по i = " + iMin + ", значение по j = " + jMin);
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
*/

/*Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника
*/
/*
int rows = 5, val = 1, i, j;
Console.WriteLine("Треугольник Паскаля");
for (i = 0; i < rows; i++)
{
    for (int b = 1; b <= rows - i; b++)
        Console.Write(" ");
    for (j = 0; j <= i; j++)
    {
        if (j == 0 || i == 0)
            val = 1;
        else
            val = val * (i - j + 1) / j;
        Console.Write(val + " ");
    }
    Console.WriteLine();
}
*/

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
*/
/*
int[,] arr = new int[3, 4];
GetRandom(arr);
Print(arr);


int s = 1;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            if (arr[i, k] > arr[i, k + 1])
            {

                s = arr[i, k];
                arr[i, k] = arr[i, k + 1];
                arr[i, k + 1] = s;
            }
        }
    }
}
System.Console.WriteLine();
Print(arr);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
*/
/*
int[,] mass = new int[3, 5];
GetRandom(mass);
Print(mass);
int summ = 0;
int min = Int32.MaxValue;
int iMin = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        summ = summ + mass[i, j];
    }
    if(min > summ)
    {
        min = summ;  
        iMin = i; 
    }
     summ = 0;  
    
}
 System.Console.WriteLine( "минимальня сумма = " + min);
  System.Console.WriteLine("индекс строки по i = " + iMin);
  for (int j = 0; j < mass.GetLength(1); j++)
  {
    System.Console.Write(mass[iMin, j] + " ");
  }
  System.Console.WriteLine();
  */


/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц*/

/*
int[,] MultiplyMatrix(int[,] mass, int[,] arr)
{
    int rA = mass.GetLength(0);
    int cA = mass.GetLength(1);
    int rB = arr.GetLength(0);
    int cB = arr.GetLength(1);
    int temp = 0;

    int[,] res = new int[rA, cB];
    if (cA != rB)
    {
        System.Console.WriteLine("матрица не может быть перемножена");
    }
    else
    {
        for (int i = 0; i < rA; i++)
        {
            for (int j = 0; j < cB; j++)
            {
                temp = 0;
                for (int k = 0; k < cA; k++)
                {
                    temp += mass[i, k] * arr[k, j];
                }
                res[i, j] = temp;
            }

        }
        
    }
    return res;
}

int[,] mass = new int[2, 2];
GetRandom(mass);
Print(mass);
System.Console.WriteLine();

int[,] arr = new int[2, 2];
GetRandom(arr);
Print(arr);

int[,] res =  MultiplyMatrix(mass,arr);
Print(res);

*/
/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/

/*

bool Check(int[,,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

int[,,] arr = new int[3, 4, 5];
Random random = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
           while(true) 
           {
            int rnd = random.Next(10, 100);
            if (!Check(arr, rnd))
            {
                arr[i, j, k] = rnd;
                break;
            }
           }

        }
    }
}


for (int i = 0; i < arr.GetLength(0); i++)
{
    System.Console.WriteLine("стр № " + (i + 1));

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            System.Console.Write(arr[i, j, k] + "[ " + i + ", " + j + ", " + k + " ]" + "   ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

*/




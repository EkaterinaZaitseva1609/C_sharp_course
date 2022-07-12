/*Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2
*/
/* function
void getRes()
{
   int[] arr = new int[8];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    System.Console.Write(arr[i] + " ");
}
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        res = res + 1;
    }
}
System.Console.WriteLine(" -> " + res);
}

getRes();
*/

/*int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    System.Console.Write(array[i] + " ");
}
int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        res = res + 1;
    }
}
System.Console.WriteLine(" -> " + res);
*/

/*
Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
// function
/*
void getSumm()
{
    int[] massiv = new int[6];

for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(10, 100);
    System.Console.Write(massiv[i] + " ");
}
System.Console.WriteLine();
int res = 0;
for (int i = 1; i < massiv.Length; i += 2)
{
res += massiv[i];   
}
System.Console.WriteLine(res);
}
getSumm();
*/

/*
int[] mass = new int[6];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 10);
    System.Console.Write(mass[i] + " ");
}
System.Console.WriteLine();
int summ  = 0;
for (int i = 1; i < mass.Length; i += 2)
{
summ += mass[i];   
}
System.Console.WriteLine(summ);
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
*/
//function

void getDiff()
{
    double[] mass = new double[6];

    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(1, 10) + new Random().NextDouble();
        System.Console.Write(Math.Round(mass[i], 2) + " ");
    }
    System.Console.WriteLine();

    double res = 0;
    double max = mass[0];
    double min = mass[0];
    for (int i = 1; i < mass.Length; i++)
    {
        if (mass[i] < min)
        {
            min = mass[i];
        }
        else if (mass[i] > max)
        {
            max = mass[i];
        }
        res = max - min;
    }
    System.Console.Write(Math.Round(res, 2));
    System.Console.WriteLine();
}
getDiff();


/*
double[] mass = new double[6];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 10) + new Random().NextDouble();
    System.Console.Write(Math.Round (mass[i], 2) + " ");
}
System.Console.WriteLine();

double res = 0;
double max = mass[0];
double min = mass[0];
for (int i = 1; i < mass.Length; i++)
{
    if (mass[i] < min)
    {
        min = mass[i];
    }
     else if (mass[i] > max)
    {
        max = mass[i];
    }
    res = max - min;
}
System.Console.Write(Math.Round (res, 2));
System.Console.WriteLine();
 */






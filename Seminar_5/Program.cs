/* Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/

//function
/*
void getRes()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
   
}
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}
int negative = 0;
int positive = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        negative +=  array[i];
    }
    else
    {
        positive += array[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine("отрицательные -> " + negative + ", положительные -> " + positive);
}

getRes();
*/
/*
int[] array = new int[12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
   
}
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}

int negative = 0;
int positive = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        negative +=  array[i];
    }
    else
    {
        positive += array[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine(negative + ", " + positive);
*/

/*
Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
/*
void print()
{
    int[] mass = new int[4];
    System.Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-100, 100);
    }
    for (int i = 0; i < mass.Length; i++)
    {
        System.Console.Write(mass[i] + " ");
    }
    System.Console.Write("] -> ");
    System.Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < 0)
        {
            mass[i] = mass[i] * (-1);
        }
        else
        {
            mass[i] = mass[i] / (-1);
        }
        System.Console.Write(mass[i] + " ");
    }
    System.Console.WriteLine("]");
}

print();
*/

/*
int[] mass = new int[4];
System.Console.Write("[");
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
for (int i = 0; i < mass.Length; i++)
{
    System.Console.Write(mass[i] + " ");
}
System.Console.Write("] -> ");
System.Console.Write("[");
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] < 0)
    {
        mass[i] = mass[i] * (-1);
    }
    else 
    {
        mass[i] = mass[i] / (-1);    
    }
    System.Console.Write(mass[i] + " ");
}
System.Console.WriteLine("]");
*/

/*
Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/


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

/*
bool checkNum (int[] arr, int num) 
{
   System.Console.Write(" arr [");
for (int i = 0; i < arr.Length; i++)
{
 System.Console.Write(arr[i] + ", ");
}
System.Console.Write("]");

bool check = false;
for (int i = 0; i < arr.Length; i++)
{
    if (num == arr[i])
    {
    check = true;
    }
}
return check;
}


Console.WriteLine("Введите  число");
int num = int.Parse(Console.ReadLine());
int[] mass = {33, 44, 5, 7, 8, 9};
bool res = checkNum (mass, num);
System.Console.WriteLine(res);

*/

/*
Console.WriteLine("Введите  число");
int num = int.Parse(Console.ReadLine());

int[] array = { 1, 3, 4, 16, 8, 88 };
System.Console.Write(" array [");
for (int i = 0; i < array.Length; i++)
{
 System.Console.Write(array[i] + ", ");
}
System.Console.Write("]");

bool check = false;
for (int i = 0; i < array.Length; i++)
{
    if (num == array[i])
    {
    check = true;
    }
    
}
System.Console.WriteLine(" -> " + check);
*/

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*
void getRes()
{
int[] massiv = new int[123];
System.Console.Write("[");
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(0, 200);
}
for (int i = 0; i < massiv.Length; i++)
{
    System.Console.Write(massiv[i] + " ");
}
System.Console.Write("] -> ");
int res = 0;
int numA = 9;
int numB = 100;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] > numA && massiv[i] < numB)
    {
        res += 1;
    }
}
System.Console.Write(res + " ");
System.Console.WriteLine();
}

getRes();
*/

/*
int[] massiv = new int[123];
System.Console.Write("[");
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(0, 200);
}
for (int i = 0; i < massiv.Length; i++)
{
    System.Console.Write(massiv[i] + " ");
}
System.Console.Write("] -> ");
int res = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] > 9 && massiv[i] < 100)
    {
        res += 1;
    }
}
System.Console.Write(res + " ");
*/

/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


void PrintArr (int[] arr)
{

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr[i] + " ");
}
System.Console.WriteLine();
}

int[] arr = new int[5];
int[] array = new int[(arr.Length + 1) / 2];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
}

PrintArr(arr);

array[array.Length - 1] = arr[arr.Length / 2];

for (int i = 0; i < arr.Length / 2; i++)
{
    array[i] = arr[i] * arr[arr.Length - 1 -i];
}

PrintArr(array);




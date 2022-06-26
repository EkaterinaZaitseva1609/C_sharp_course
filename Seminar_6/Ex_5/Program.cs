/*
Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. 
*/

int[] arr = new int [6];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10); 
    System.Console.Write(arr[i] + " ");
}
System.Console.WriteLine();
int[] arr1 = new int [arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    arr1[i] = arr[i];
}

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr1[i] + " ");
}
System.Console.WriteLine();

int[] arr2 = arr;
System.Console.WriteLine(arr2);
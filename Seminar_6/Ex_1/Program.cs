/* Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/
int[] getMass()
{
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
        System.Console.Write(arr[i] + " ");
    }
 return arr;
}


/*
int[] arr = new int [6];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10); 
    System.Console.Write(arr[i] + " ");
}
System.Console.WriteLine();
int x  = 0;
for (int i = 0; i < arr.Length / 2; i++)
{
    x = arr[i];
    arr[i] = arr [arr.Length - 1 - i];
    arr [arr.Length - 1- i] = x;
}

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr[i] + " ");
}
System.Console.WriteLine();
*/


void getRes()
{
    int[] arr = getMass();
    System.Console.WriteLine();
    
    int x = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        x = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = x;
    }

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

getRes();
/*Задача 30: Напишите программу, которая выводит
массив из 8 элементов, заполненный нулями и
единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

/*int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);

}
Array.ForEach(array, Console.Write);
System.Console.WriteLine();
*/


void doArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    Array.ForEach(arr, Console.Write);
    System.Console.WriteLine();
}


 doArray();













//new Random().Next(0, 1);
//System.Console.WriteLine(array);

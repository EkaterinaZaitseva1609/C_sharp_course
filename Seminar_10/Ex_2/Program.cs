/*Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
представления нескольких чисел (без разделителя). В массиве data хранится
информация о количестве бит, которые занимают числа из массива info.
Напишите программу, которая составит массив десятичных представлений чисел
массива data с учётом информации из массива info.
25 мин
входные данные:
- data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
- info = {2, 3, 3, 1 }
выходные данные:
- 1, 7, 0, 1
*/
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i] + " ");
    }
    System.Console.WriteLine();
}


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int[] cdata = new int[info.Length];

int k = 0;
for (int i = 0; i < info.Length; i++)
{
    for (int j = info[i]-1, m = 0; j >= 0; j--, m++)
    {
        
        Console.Write(data[m + k]);

        cdata[i] +=(int)(data[j + k] * Math.Pow(2, m));
        
    }
    System.Console.WriteLine(cdata[i]);
    k+= info[i];
    System.Console.WriteLine();
}


System.Console.WriteLine();
PrintArr(cdata);

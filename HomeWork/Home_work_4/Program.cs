/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/*

int getPower(int x, int y)
{
    int sum = 1;
    for (int i = 1; i <= y; i++)
    {
        sum = sum * x;
    }
    return sum;
}

System.Console.WriteLine("Введите число");
int a = Int32.Parse(Console.ReadLine()); 

System.Console.WriteLine("Введите число");
int b = Int32.Parse(Console.ReadLine()); 

int sum = getPower (a, b);
System.Console.WriteLine(a + ", " + b + " -> " + sum + " в " + b + " степени");
*/


/*
System.Console.WriteLine("Введите число");
int A = Int32.Parse(Console.ReadLine()); 

System.Console.WriteLine("Введите число");
int B = Int32.Parse(Console.ReadLine()); 

int Res = 1;
for (int i = 1; i <= B; i ++)
{
    Res = Res * A;
}
System.Console.WriteLine(A + ", " + B + " -> " + Res + " в " + B + " степени");
*/


/*
Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int getSum(int N)
{
    int res = 0;
    while (N != 0)
    {
        res = res + (N % 10);
        N = N / 10;
    }
    return res;
}

System.Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine()); 

int res = getSum (num);
System.Console.WriteLine(num + " -> " + res);
*/


/*
System.Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine());

int res = 0;
while (num != 0)
{
    res = res + (num % 10);
    num = num / 10;
}
System.Console.WriteLine(res);
*/

/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);

}
Array.ForEach(array, Console.Write);
System.Console.WriteLine();
*/

void getArr (int[] arr)
{
System.Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if (i == arr.Length -1)
    {
        System.Console.Write(arr[i]);
    }
    else
    {
        System.Console.Write(arr[i] + ", ");
    }
}
System.Console.WriteLine("]");
}

int[] array = {4, 5, 6, 7, 8, 3, 4, 5};
getArr (array);


/*
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

System.Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length -1)
    {
        System.Console.Write(array[i]);
    }
    else
    {
        System.Console.Write(array[i] + ", ");
    }
}
System.Console.WriteLine("]");
*/

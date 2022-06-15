/*
Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */


public class Seminar3Ex4
{
    public static void Main()
    {
        System.Console.WriteLine("Введите число");
        int num = int.Parse(Console.ReadLine());
        if (num >= 0)
        for (int i = 1; i <= num; i++)
        {
            System.Console.WriteLine(Math.Pow(i, 2));
        }
    else
        {
            System.Console.WriteLine("введите положительное число");
        }
    }

}
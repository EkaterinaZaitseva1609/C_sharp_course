﻿/*
Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/


public class Seminar3Ex2
{
    public static void Main()
    {
        System.Console.WriteLine("Введите номер четверти");
        int num = int.Parse(Console.ReadLine());

        if (num == 1)
        {
            System.Console.WriteLine("x > 0; y > 0");
        }
        else if (num == 2)
        {
            System.Console.WriteLine("x < 0; y > 0");
        }
        else if (num == 3)
        {
            System.Console.WriteLine("x < 0; y < 0");
        }
        else if (num == 4)
        {
            System.Console.WriteLine("x > 0; y < 0");
        }
        else {
            System.Console.WriteLine("ошибочно задан номер четверти");
        }
    }

}
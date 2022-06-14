/*
Задача 21: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
*/



public class Seminar3Ex3
{
    public static void Main()
    {
        System.Console.WriteLine("Введите координату точки А(x)");
        int Ax = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки А(y)");
        int Ay = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки B(x)");
        int Bx = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки В(y)");
        int By = int.Parse(Console.ReadLine());

        if (Ax == 0 && Ay == 0 && Bx == 0 && By == 0)
        {
            System.Console.WriteLine("0");
        }
        else
        {
            int res1 = (Bx - Ax);
            double res2 = Math.Pow(res1, 2);
            System.Console.WriteLine(res2);

            int res3 = (By - Ay);
            double res4 = Math.Pow(res3, 2);
            System.Console.WriteLine(res4);

            double res5 = res2 + res4;

            double result = Math.Sqrt(res5);
            System.Console.WriteLine("Расстояние между точками = " + Math.Round(result));

        }
        
    }
}
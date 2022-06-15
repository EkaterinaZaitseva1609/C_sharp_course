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
        double Ax = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки А(y)");
        double Ay = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки B(x)");
        double Bx = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки В(y)");
        double By = double.Parse(Console.ReadLine());

        if (Ax == 0 && Ay == 0 && Bx == 0 && By == 0)
        {
            System.Console.WriteLine("0");
        }
        else
        {
            double res1 = (Bx - Ax);
            double res2 = Math.Pow(res1, 2);
            System.Console.WriteLine(res2);

            double res3 = (By - Ay);
            double res4 = Math.Pow(res3, 2);
            System.Console.WriteLine(res4);

            double res5 = res2 + res4;

            double result = Math.Sqrt(res5);
            System.Console.WriteLine("Расстояние между точками = " + Math.Round(result, 2));

        }
        
    }
}
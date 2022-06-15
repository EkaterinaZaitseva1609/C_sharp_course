/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
*/
/*
public class Home_work_3
{
    public static void Main()
    {
        System.Console.WriteLine("Введите пятизначное число");
        int n = int.Parse(Console.ReadLine());

        int a = n / 10000;
        int e = n % 10;
        int b = (n / 1000) % 10;
        int d = (n % 100) / 10;
        if (a == e && b == d)
        {
            System.Console.WriteLine("Данное пятизначное значение является палиндромом");
        }
        else
        {
            System.Console.WriteLine("не палиндром");
        }
    }
} */

/*Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.*/
/*
public class  Home_work_3
{
    public static void Main()
    {
        System.Console.WriteLine("Введите координату точки А(x)");
        double Ax = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки А(y)");
        double Ay = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки А(z)");
        double Az = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки B(x)");
        double Bx = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки В(y)");
        double By = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите координату точки В(z)");
        double Bz = double.Parse(Console.ReadLine());

        if (Ax == 0 && Ay == 0 && Az == 0 && Bx == 0 && By == 0 && Bz == 0)
        {
            System.Console.WriteLine("0");
        }
        else
        {
            double res1 = (Bx - Ax);
            double res2 = Math.Pow(res1, 2);
            
            double res3 = (By - Ay);
            double res4 = Math.Pow(res3, 2);
            
            double res5 = (Bz - Az);
            double res6 = Math.Pow(res5, 2);
          
            double res7 = res2 + res4 + res6;

            double result = Math.Sqrt(res7);
            System.Console.WriteLine("Расстояние между точками = " + Math.Round(result, 2));

        }
        
    }
} */

/*
Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125*/

public class Home_work_3
{
    public static void Main()
    {
        System.Console.WriteLine("Введите число N");
        int num = int.Parse(Console.ReadLine());
        if (num >= 0)
        for (int i = 1; i <= num; i++)
        {
            System.Console.WriteLine(Math.Pow(i, 3));
        }
    else
        {
            System.Console.WriteLine("введите положительное число");
        }
    }

}
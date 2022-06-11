public class Seminar2Ex4
{
    public static void Main()
    {
        System.Console.WriteLine("Введите трехзначное число");
        int num = Int32.Parse(Console.ReadLine());

        if (num < 100)
        {
            System.Console.WriteLine("Нет третьего числа");
        }
        else
        {
            while (num >= 1000)
            {
                num = num / 10;
            }
            int num3 = num % 10;
            System.Console.WriteLine(num3);

        }

    }

}


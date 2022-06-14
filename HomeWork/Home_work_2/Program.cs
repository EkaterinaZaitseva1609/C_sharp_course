/*
Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа. */


/*public class Seminar2Ex4
{
    public static void Main()
    {
        System.Console.WriteLine("Введите трехзначное число");
        int num = Int32.Parse(Console.ReadLine());
        if (num < 10)
        {
            System.Console.WriteLine("У данного числа нет второго значения");
        }
        else
        {
            while (num >= 100)
            {
                num = num / 10;
            }
            int numRes = num % 10;
            System.Console.WriteLine(num + " -> " + numRes);
        }
    }

}

*/


/*
Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
*/

public class Seminar2Ex4
{
    public static void Main()
    {

        System.Console.WriteLine("Введите порядковый номер дня недели  - от 1 до 7");
        int num = Int32.Parse(Console.ReadLine());

        if (num > 7 || num < 0)
        {
            System.Console.WriteLine("Вы ошиблись, в неделе всего 7 дней");
        }
        else if (num ==7 || num == 6)
        {
            System.Console.WriteLine("Ура, выходной!");
        }
        else
        {
            System.Console.WriteLine("Будний день");
        } 
    }
}
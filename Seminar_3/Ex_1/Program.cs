/*17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
*/



public class Seminar3Ex1
{
    public static void Main()
    {
        System.Console.WriteLine("Введите x");
        int x = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите y");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            System.Console.WriteLine("Первая плоскость");
        }
        else if (x < 0 && y > 0)
        {
            System.Console.WriteLine("Вторая плоскость");
        }
        else if (x < 0 && y < 0)
        {
            System.Console.WriteLine("Третья плоскость");
        }
        else if (x > 0 && y < 0)
        {
            System.Console.WriteLine("Четвертая плоскость");
        }
        else {
            System.Console.WriteLine("Координаты не принадлежат плоскости");
        }
    }
}
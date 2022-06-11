public class Seminar2Ex4
{
    public static void Main()
    {
        System.Console.WriteLine("Введите любое число");
        int num = Int32.Parse(Console.ReadLine());

        if (num % 7 == 0 && num % 23 == 0)
        {
            System.Console.WriteLine(num + " -> " + "yes");
        }
        else
        {
            System.Console.WriteLine(num + " -> " + "No");
        }
    }
}

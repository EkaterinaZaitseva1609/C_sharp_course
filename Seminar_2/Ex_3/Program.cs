public class Seminar2Ex3
{
    public static void Main()
    {
        System.Console.WriteLine("Введите первое число");
        int num1 = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Введите второе число");
        int num2 = Int32.Parse(Console.ReadLine());
if (num1 % num2 == 0)
{
    System.Console.WriteLine(num1 + "," + num2 + " -> кратно");
}
else
{
    System.Console.WriteLine(num1 + "," + num2 + " -> не кратно, " + "остаток " + num1 % num2);
}
    }


}
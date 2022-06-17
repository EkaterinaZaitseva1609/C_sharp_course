/*Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А */


int func(int size)
{
    System.Console.WriteLine("start");
    int sum = 0;
    for (int i = 0; i <= size; i++)
    {
        System.Console.WriteLine("i =  " +  i);
        sum += i;
        System.Console.WriteLine("sum = " + sum);
    }
    System.Console.WriteLine("end");
    return sum;
}

System.Console.WriteLine("Введите  положительное число");
int A = Int32.Parse(Console.ReadLine());

System.Console.WriteLine("Res: " + func(A));






/*public class Seminar4Ex1
{
    public static void Main()
    {
        System.Console.WriteLine("Введите  положительное число");
        int A = Int32.Parse(Console.ReadLine());

if (A < 0)

{
    System.Console.WriteLine("Нужно ввести положительное число");
    return;
}
        /*int summ = 0;
        for (int i = 0; i <= A; i++)
        {
            summ = summ + i;
        }

        System.Console.WriteLine(summ); */












/*Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.  Нахождение факториала */

int getFact (int x)
{
    int sum = 1;
    for (int i = 1; i <= x; i ++)
    {
        sum = sum * i;
    }
    return sum;
}

Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine());
int summ = getFact(num);
System.Console.WriteLine("факториал от " +  num + " =  " + summ);





/*Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine());
int res = 1;
for (int i = 1; i <= num; i++)
{
    res = res * i;
    if (i == num)
    {
        System.Console.Write(i);
    }
    else
    {
        System.Console.Write(i + " *");
    }
}

System.Console.Write(" = " +  res);
*/





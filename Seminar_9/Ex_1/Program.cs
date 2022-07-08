// Рекурсия 

/*
void Rec(int n)
{
    if (n == 0)
    {
        System.Console.WriteLine("Finish");
        return;

    }
    System.Console.WriteLine("Start");
        Rec(n-1);
}

Rec(10);

*/
/*
void Foo(int i)
{
    System.Console.WriteLine(i);
    if (i >= 3)
        return;
    i++;
    Foo(i);
}

Foo(0);
*/

/*
Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
/*
void Rec(int n)
{
    System.Console.Write(n + " ");
   
    if (n >= 5)
    {
        return;
    }
    n++;
    Rec(n);
     System.Console.WriteLine();
}
Rec(1);
*/
/*
Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" 
*/
/*
void Rec(int n, int m)
{
   System.Console.Write(n + " ");
   
    if (n >= m)
    {
        return;
    }
    n++;
    Rec(n, m);
     System.Console.WriteLine();
}
Rec(2, 8); 
*/
/*
Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
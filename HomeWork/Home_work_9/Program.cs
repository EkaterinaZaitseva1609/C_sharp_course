/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/
/*
System.Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine());

void Forvard (int m, int n)
{
        if (n < m)
        {
            return;
        }
        Forvard (m, n - 1);
        System.Console.WriteLine(n);
}  
        
void Reverse (int m, int n)
{
    if (m < n)
    {
        return;
    }
    System.Console.WriteLine(m);
    Reverse(m - 1, n);
}
System.Console.WriteLine();
if (m < n)
{
   Forvard (m, n);
} 
else 
{
 Reverse (m, n);
}
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
System.Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine());

int GetSum (int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return GetSum(m +1, n) + m;

}
int res = GetSum (m, n);
System.Console.WriteLine(res);
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/


System.Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine());

if (n < 0 || m < 0)
{
    System.Console.WriteLine("ошибка");
    return;
}
int A(int m, int n)
{

    if (m == 0) return n + 1;
    if (n == 0) return A(m - 1, 1);
    return A(m - 1, A(m, n - 1));
}
Console.WriteLine(A(n, m));


/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
*Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

System.Console.WriteLine("Введите число A ");
int A = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число B ");
int B = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число C ");
int C = Int32.Parse(Console.ReadLine());

if (A + B > C && B + C > A && C + A > B)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}



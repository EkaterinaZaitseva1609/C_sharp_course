/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
/*
System.Console.WriteLine("Введите M чисел через запятую");
string[] arr = Console.ReadLine().Split(',');

int[] mass = new int [arr.Length];
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    int x = Int32.Parse(arr[i]);
   if (x > 0)
    {
        res = res + 1;
    }
}
System.Console.WriteLine("-> " + res);

*/

/*
Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =
9 -> (-0,5; 5,5)
*/

System.Console.WriteLine("Введите точку B1");
int B1 = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите точку K1");
int K1 = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите точку B2");
int B2 = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите точку k2");
int K2 = Int32.Parse(Console.ReadLine());

int x = 0;
x = (B2 - B1) / (K1 - K2);
System.Console.WriteLine(x + ", " + K1 * x + B1);


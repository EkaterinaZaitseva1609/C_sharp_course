/*5. Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.*/

System.Console.WriteLine("Введите целое число");
int n = Int32.Parse(Console.ReadLine());

for (int i = -n; i <= n; i++)
{
    System.Console.WriteLine(i);
}
 
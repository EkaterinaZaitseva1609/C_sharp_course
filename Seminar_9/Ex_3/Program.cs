/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

System.Console.WriteLine("Введит число");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введит степень числа");
int d = int.Parse(Console.ReadLine());

int GetDeg(int n, int d)
{

    if (d == 0)
    {
        return 1;
    }
        return n * GetDeg(n, d -1);
        
    

}

int result = GetDeg(n, d);
System.Console.WriteLine(result);





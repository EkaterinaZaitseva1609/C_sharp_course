/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
 */


System.Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine());
int res = 0;
string result = string.Empty; 
while (num > 0)
{
    res = num % 2;
    num = num / 2;
    result = res + result; 
}

System.Console.WriteLine(result);




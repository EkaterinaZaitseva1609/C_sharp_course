/*
Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/




/*

int sum = 0;
while(num != 0)
{
    sum = sum + num % 10;
    num = num / 10; 
}
System.Console.WriteLine(sum);
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
System.Console.WriteLine("Введит число");
int numb = int.Parse(Console.ReadLine());

/*
int GetSum(int num)

    {
        if (num == 0) return 0;
        return GetSum(num / 10) + num % 10;
    }

int get = GetSum(numb); 
System.Console.WriteLine(get);
*/


int GetSum(int num)
{
System.Console.WriteLine("num =" + num );
    int sum = 0;
    if (num == 0)
    {
        return 0;
    }
    else
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    int res = GetSum(num);
    System.Console.WriteLine("res = " + res);
    return sum + res;

}
int get = GetSum(numb);
System.Console.WriteLine(get);
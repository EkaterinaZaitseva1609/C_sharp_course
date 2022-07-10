// Собрать строку с числами от a до b, a<=b
/*

string NumberFor (int a, int b)
{
    string result = string.Empty;
    for(int i = a; i <= b; i++)
    {
        result += i;
    }
    return result; 
}

string res = NumberFor (2, 7);
System.Console.WriteLine(res);

*/
/*
void NumberFor (int a, int b)
{
    for(int i = a; i <= b; i++)
    {
    System.Console.WriteLine(i);
    }   
}

NumberFor (2, 7);
//System.Console.WriteLine(i);
*/

//Рекурсия - Собрать строку с числами от a до b, a<=b
/*
string NumberFor (int a, int b)
{
    if (a < b) return a + NumberFor (a + 1,b);
else return "" + b;
}

System.Console.WriteLine(NumberFor(1, 10));
*/

//Рекурсия - Собрать строку с числами от b до a
/*
string NumberFor (int a, int b)
{
    if (b > a) return b + NumberFor (a,b - 1);
else return "" + a;
}

System.Console.WriteLine(NumberFor(1, 10));
*/

// Сумма чисел от 1 до n
/*
int SumRec (int n)
{
    if (n == 0)
    {
        return 0;
    }
    else return n + SumRec (n - 1);
}
System.Console.WriteLine(SumRec(4));
*/
//Факториал от числа n
/*
int GetRes(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else return n *= GetRes(n - 1);
    
}
System.Console.WriteLine(GetRes (8));
*/
// Вычеслить A в степени N
/*
int GetNum (int a, int n)
{
    if (n == 0) return 1;
    else return a *= GetNum(a, n-1);
}
System.Console.WriteLine(GetNum(5, 2));

*/


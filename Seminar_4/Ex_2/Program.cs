/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе. */

/*int func(int size)
{
    string str = size.ToString();
    return str.Length;

}

System.Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine()); 

int res = func (num);
System.Console.WriteLine(res);

*/

/*System.Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine()); 
string str = num.ToString();
int sum = 0;

System.Console.WriteLine(str.Length);

*/



int func( int num)
{
   int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;

}

Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine()); 

System.Console.WriteLine(func(num));


/* System.Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine()); 

int count = 0;
while (num != 0)
{
num = num / 10;
count++; 
}
System.Console.WriteLine(count); */


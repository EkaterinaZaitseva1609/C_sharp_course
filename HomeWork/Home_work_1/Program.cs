/*Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
*/

System.Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine("max = " + a);
}
else if (a < b)
{
    System.Console.WriteLine("max = " + b);
}
else //if (a = b)
{
    System.Console.WriteLine("Значения равны");
}


/*Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
*/

System.Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int[] number = { a, b, c };
int max = number[0];

for (int i = 1; i < number.Length; i++)
{
    if (max < number[i])
    {
        max = number[i];
    }
}
{
    System.Console.WriteLine(a + ", " + b + ", " + c + " -> " + max);
}


/*Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).*/

System.Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());

if (Num % 2 == 0)
{
    System.Console.WriteLine(Num + " -> да");
}
else 
{
    System.Console.WriteLine(Num + " -> нет");
}


//другой вариант решения

System.Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());

bool isEven = Num % 2 == 0;
if(isEven == true)
{
  System.Console.WriteLine("да");  
}
else
{
System.Console.WriteLine("нет");  
}

/*Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.*/

System.Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());
System.Console.WriteLine("результат");
   
for (int sum = 2; sum < Num; sum += 2)
{
  System.Console.WriteLine(sum); 
}

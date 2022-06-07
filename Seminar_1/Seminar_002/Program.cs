//1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.

System.Console.WriteLine("Введите первое число");
int firstNum = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int  secondNum = Int32.Parse(Console.ReadLine());

if (firstNum / secondNum == secondNum)
{
    System.Console.WriteLine("да, квадрат от " + secondNum + " равен " +  firstNum);
}
else
{
    System.Console.WriteLine("нет, это не верный ответ");
}
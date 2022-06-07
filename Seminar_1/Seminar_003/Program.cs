//3. Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

string[] day = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
System.Console.WriteLine("Введите порядковый номер дня недели  - от 1 до 7");
int num = Int32.Parse(Console.ReadLine());

if (num <= 7 && num > 0 )
{
System.Console.WriteLine(day[num-1]);
}
else
{
   System.Console.WriteLine("Ошибка"); 
}

// Методы

//модификаторы  тип_возвращаемого_значения  название_метода(параметры)
// {
//   тело метода 
// }


int GetSum (int a, int b)
{
    int result = a * b;

    return result;
} 

/*
int a, b, c;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());


c = GetSum(a,b);
System.Console.WriteLine(c);
*/

*/
/* метод ничего не принимает и ничего не отдает, лишь печатает в консоль 
void prinLine()
{
    System.Console.WriteLine("Метод был вызван");

}

prinLine();
*/
// 
void Printresult (int result)
{
System.Console.WriteLine("результат сложения " + result);
}

int a, b, c;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());


c = GetSum(a,b);
Printresult(c);
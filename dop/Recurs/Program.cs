// Рекурсия - вызов метода самого себя

/*
void Foo(int i)
{
    System.Console.WriteLine(i);
    if (i >= 3)
        return;
    i++;
    Foo(i);
}

Foo(0);
*/
// вывод массива с помощью рекурсии
/*
void PrintArr(int[] myArr, int i = 0)
{
    if (i < myArr.Length)
    {
        System.Console.WriteLine(myArr[i]);
        PrintArr(myArr, i + 1);
    }
}

int[] myArr = { 5, 3, 2 };
PrintArr(myArr);
*/

//Найти сумму элементов массива с помощью рекурсии
/*
int Sum(int[] myArr, int i = 0)
{
    if(i >= myArr.Length)
    
        return 0;

        return myArr[i] + Sum(myArr, i + 1);
}


int[] myArr = {5, 3, 2};
int result = Sum(myArr);
System.Console.WriteLine(Sum(myArr));
*/

//Найти сумму чисел числа: 561 = 12

int Bar(int value)
{
    if(value < 10)
    return value;

    return value % 10 + Bar(value / 10);

}


int myValue = 561;
int result = Bar(myValue);
System.Console.WriteLine(Bar(myValue));

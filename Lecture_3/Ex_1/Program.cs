//Function (Method) 

// Вид 1 - методы, которые ничего не возвращают и не принимают 
void Method1()
{
   Console.WriteLine("автор");

}

//Method1(); //вызвать метод

//Вид 2 (Method2) Методы, которые ничего не возвращают, но могут принимать какие-то аргументы
void Method2(string msg)
{
System.Console.WriteLine(msg);
}
//Method2("Текст сообщения"); //вызвать метод

//(Method2.1) именованные аргументы (к какому аргументу, какое значение мы хотим указать, используется, когда аргументов больше одного)

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
       System.Console.WriteLine(msg);
        i++;
    }
}
//Method21 (msg: "text" , count: 4);

//Вид 3 (Method3)  Метод что-то возвращает, но ничего не принимает

int Method3() //аргументы не принимает
{
    return DateTime.Now.Year;
}

int year = Method3();
//System.Console.WriteLine(year);

//Вид 4 (Method4) //методы, которые что-то принимают и возвращают
// 4 вид наиболее часто используется 

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i ++;
    }
    return result;
}string res = Method4(19, "a");
System.Console.WriteLine(res);
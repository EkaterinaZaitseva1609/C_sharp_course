//рекурсия 

int Rec(int num, int b)
{
    if (num <= 0) //условие остановки
    {
        return 1; // пишем для того, чтобы функция прекратилась (return - стой)
    }
    System.Console.WriteLine("рекурсия" + num);
    return Rec(num - 1, b) * b; //рекурсивыный вызов, вызываем рекурсивную функцию в себя 
}

System.Console.WriteLine(Rec(4, 5));
 // 5 раз написали "рекурсия "
﻿/* Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
одно из разбиений на группы N ≤ 10²⁰.

Например, для N = 50, M получается 6
- Группа 1: 1
- Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
- Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
- Группа 4: 8 12 18 20 27 28 30 42 44 45 50
- Группа 5: 7 16 24 36 40
- Группа 6: 5 32 48
*/
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == 0)
                break;
            else
            {
                System.Console.Write(arr[i, j] + " ");
            }
        }
        System.Console.WriteLine();
    }

}
int N = 20;

int[,] myArr = new int[N, N];
myArr[0, 0] = 1;
myArr[1, 0] = 2;

for (int k = 3; k < N; k++)
{
    bool stop = false;
    for (int i = 1; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            if (myArr[i, j] == 0)
            {
                myArr[i, j] = k;
                stop = true;
                break;
            }
            else
            {
                if (k % myArr[i, j] != 0)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

        }
        if (stop == true)
        {
            break;
        }
    }
    }
    Print(myArr);


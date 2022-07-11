/* Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/
/*
int GetFib(int a, int b, int n)
{
    if (n == 1) return a;
    if (n == 2) return b;
    return GetFib(a, b, n - 1) + GetFib(a, b, n - 2);

}
for (int i = 1; i <= 5; i++)
{
    System.Console.Write(GetFib(3, 4, i));
}

System.Console.WriteLine();
*/
/*
Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
и «в». Покажите все слова, состоящие из n букв, которые можно построить из
букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
ав, ва, ви, ив, св, вс
*/
/*
string[] mass = new string[4] { "а", "и", "с", "в" };

    for(int i = 0; i < mass.Length; i++)
    {
    for (int j = 0; j < mass.Length; j++)
    {
        System.Console.Write(mass[i] + mass[j] + " ");
    }
}
System.Console.WriteLine();

*/
string[] Words(string[] alf, int n)
{
    if (n == 0)
    {
        string[] res = new string[1];
        res[0] = "";
        return res;
    }
    string[] temp = Words(alf, n - 1);
    string[] result = new string[temp.Length * alf.Length];
    int index = 0;
    for (int i = 0; i < temp.Length; i++)
    {
        for (int j = 0; j < alf.Length; j++)
        {
            result[index] = temp[i] + alf[j];
            index++;
        }
    }
    return result;
}



string[] alf = { "а", "и", "с", "в" };
System.Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine();
string[] res = Words(alf, n);

for (int i = 0; i < res.Length; i++)
{
    System.Console.Write(i + ")" + res[i] + " ");
}
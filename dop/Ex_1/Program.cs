void staircase(int n)
{

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j >= i)
            {
                System.Console.Write("#");
            }
            else
            {
                System.Console.Write(" ");
            }

        }
        System.Console.WriteLine("");
    }

}
staircase(4);


void staircase(int n)
{

    for (int i = n - 1; i >= 0; i--)
    {
        for (int j = 0; j < n; j++)
        {
            if (j >= i)
            {
                System.Console.Write("#");
            }
            else
            {
                System.Console.Write(" ");
            }

        }
        System.Console.WriteLine("");
    }

}
staircase(4);

/*
void miniMaxSum(List<int> arr)
{
    long summ = 0;
     long max = 0;
     long min = Int32.MaxValue;
    for (int j = 0; j < arr.Count; j++)
    {
       
        for (int i = 0; i < arr.Count; i++)
        {
            if (j != i)
            {   
                summ = summ + arr[i];
            }
        }
        System.Console.WriteLine(summ);
        if (summ > max)
            {
                max = summ;
            }
            if (summ < min)
            {
                min = summ;
            }
        summ = 0;
    }
System.Console.WriteLine(min + " " + max);
}
List<int> mass = new List<int>() { 1, 2, 3, 4, 5 };
miniMaxSum(mass);
*/

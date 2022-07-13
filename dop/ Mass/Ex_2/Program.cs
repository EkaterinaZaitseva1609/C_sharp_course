List<int> arr = new List<int>();
arr.Add(-4);
arr.Add(3);
arr.Add(-9);
arr.Add(0);
arr.Add(4);
arr.Add(1);

double sum1 = 0;
double sum2 = 0;
double sum3 = 0;
foreach(double a in arr)
{
    if(a > 0)
    {
    sum1 = sum1 + 1;
    }
    if (a < 0)
    {
    sum2 = sum2 + 1;
    }
    if (a == 0)
     sum3 = sum3 + 1;
}

System.Console.WriteLine (Math.Round(sum1 / arr.Count, 6));

System.Console.WriteLine (Math.Round(sum2 / arr.Count, 6));

System.Console.WriteLine (Math.Round(sum3 / arr.Count, 6));


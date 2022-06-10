 public class Seminar2Ex1
 {
    public static void Main()
    {
        int num = new Random().Next(10, 100);
int n1 = num % 10;
int n2 = num / 10;


        if (n1 > n2)
        {
            System.Console.WriteLine(num + " -> " + n1);
        }
        else
        {
            System.Console.WriteLine(num + " -> " + n2);
        }


     }
 }
public class Test1
{
    public static void Main()
    {
        byte[] nums = { 5, 6, 7, 8, 3 };
        byte res1 = Summa(nums);
        System.Console.WriteLine("Результат " + res1);
    }

    public static byte Summa(byte[] digits)
    {
        byte summ = 0;
        foreach (byte el in digits)
            summ += el;

        return summ;

    }
}

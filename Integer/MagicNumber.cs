public class MagicNumber
{
    public static void Magic(int n)
    {   
        //Magic number means sum of digits * Reverse of sum of digits = original number
        int sum = 0, r;
        int temp = n;
        //for sum of digits
        while (temp > 0)
        {
            r = temp % 10;
            sum = sum + r;
            temp = temp / 10;
        }
        System.Console.WriteLine(sum);
        temp = sum;
        int rev = 0;
        //for reverse of digits
        while (temp > 0)
        {
            r = temp % 10;
            rev = rev * 10 + r;
            temp = temp / 10;
        }
        System.Console.WriteLine(rev);
        if (rev * sum == n)
        {
            Console.WriteLine(n + " is a Magic number");
        }
        else
        {
            Console.WriteLine(n + " is not a Magic number");
        }
    }
}
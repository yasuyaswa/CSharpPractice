public class SwapNumber{
    public static void swap(){
        int a=2,b=3;
        a=a+b;
        b=a-b;
        a=a-b;
        Console.WriteLine($"a={a}, b={b}");
    }
}
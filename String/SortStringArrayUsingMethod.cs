public class SortStringArrayUsingMethod{
    public static void SortUsingMethod(){
        Console.Write("Enter the text: ");
        string input = Console.ReadLine();
        char[] a;
        int l=input.Length;
        a = input.ToCharArray(0,l);
        Array.Sort(a);
        Console.WriteLine(a);
    }
}
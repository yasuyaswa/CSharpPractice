public class FirstAndLastCharChange{
    public static void FirstLastCharChange(){
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();
        string x = input.Substring(input.Length-1)+input.Substring(1,input.Length-2)+input.Substring(0,1);
        Console.WriteLine(x);
    }
}
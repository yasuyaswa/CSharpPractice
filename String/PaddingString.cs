public class PaddingString{
    public static void Padding(){
        Console.Write("Enter the text: ");
        string input = Console.ReadLine();
        
        string NewString1 = input.PadRight(input.Length + 8, '*');
        string NewString2 = input.PadLeft(input.Length + 5, '+');
        
        Console.WriteLine(NewString1);
        Console.WriteLine(NewString2);
    }
}
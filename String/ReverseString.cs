public class ReverseStrings{
    public static void ReverseString(){
        // string e="1";
        // while(e!="0"){
        Console.Write("Enter a String : ");
        string input = Console.ReadLine();
        string result = String.Empty;
        for(int i=input.Length-1; i>=0; i--){
            result+=input[i];
        }
        Console.WriteLine(result);
        //     Console.WriteLine("\nEnter 0 for exit or any key to continue.");
        //     e=Console.ReadLine();
        // }
    }
}
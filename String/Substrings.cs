using System.Text;
public class Substrings{
    public static void Substring(){
        // string e="1";
        // while(e!="0"){
            Console.Write("Enter the string: ");
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
            {
                StringBuilder subString = new StringBuilder(input.Length - i);
                for (int j = i; j < input.Length; j++)
                {
                    subString.Append(input[j]);
                    Console.Write(subString + " ");
                }
            }
        //     Console.WriteLine("\nEnter 0 for exit or any key to continue.");
        //     e=Console.ReadLine();
        // }
            
    }
}
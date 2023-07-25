using System.Text.RegularExpressions;
public class RegularExpressionForEmail{
    public static void RegularExpression(){
        Console.Write("Enter your email to validate: ");
        string input = Console.ReadLine();
        string pattern = "^[A-Z0-9+_.-]+@[A-Z0-9.-]+$";
        
        if(Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase)){
            Console.WriteLine("Email is valid!");
        }else{
            Console.WriteLine("Email is invalid!");
        }
    }
}
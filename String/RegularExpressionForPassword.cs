using System.Text.RegularExpressions;
public class RegularExpressionForPassword{
    public static void RegularExpression(){
        Console.WriteLine("Make sure that it conatins Minimum eight and maximum 10 characters, at least one uppercase letter, one lowercase letter, one number and one special character:");
        Console.Write("Enter your Password to validate: ");
        string input = Console.ReadLine();
        string pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,10}$";
        
        if(Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase)){
            Console.WriteLine("Password is valid!");
        }else{
            Console.WriteLine("Password is invalid!");
        }
    }
}
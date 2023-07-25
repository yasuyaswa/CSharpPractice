public class AlphabetPositionInString{
    public static void AlphabetPosition(){
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();
        //a -> 97%32=1
        var CharPosition = input.ToLower().Where(ch=> Char.IsLetter(ch)).Select(ch=> (int)ch%32).ToArray();
        string result = string.Join(" ", CharPosition);
        Console.WriteLine("Alphabet position in the string is "+ result);
    }
}
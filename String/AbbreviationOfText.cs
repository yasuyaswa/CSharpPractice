public class AbbreviationOfText{
    public static void Abbreviation(){
        Console.Write("Enter the text: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string result = "";
        foreach(string item in words){
            if(item.Length>0){
                result+=item[0];
            }
        }
        Console.WriteLine(result.ToUpper());
    }
}
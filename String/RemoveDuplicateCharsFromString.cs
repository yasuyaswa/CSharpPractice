public class RemoveDuplicateCharsFromString{
    public static void RemoveDuplicate(){
        string e="1";
        while(e!="0"){
            Console.Write("Enter the string: ");
        string input = Console.ReadLine();
        string result = string.Empty;
        for(int i=0; i<input.Length; i++){
            if(!result.Contains(input[i])){
                result+=input[i];// result=result+input[i]
            }
        }
        Console.WriteLine(result);
        Console.WriteLine("Enter 0 for exit or any key to continue.");
        e=Console.ReadLine();
        }

    }
}
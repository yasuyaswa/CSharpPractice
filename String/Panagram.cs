using System.Runtime.Intrinsics.Arm;

public class Panagram{
    public static void Panagrams(){
        Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();
        bool isPanagram = true;
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        for(int i = 0; i < alphabet.Length; i++){
            if(!str.Contains(alphabet[i])){
                isPanagram = false;
                break;
            }
        }
        if(isPanagram == true){
            Console.WriteLine("The string is a panagram");
        }else{
            Console.WriteLine("The string is not a panagram");
            
        }
    }     
}
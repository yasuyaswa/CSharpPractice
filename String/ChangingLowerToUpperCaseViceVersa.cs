public class ChangingLowerToUpperCaseViceVersa{
    public static void ChangingToLowerCase(){
        Console.Write("Enter the text: ");
        string input = Console.ReadLine();
        char[] a;
        char ch;
        int l = input.Length;
        a = input.ToCharArray(0,l);
        for(int i=0; i<l; i++){
            ch=a[i];
            if(char.IsLower(ch)){
                Console.Write(char.ToUpper(ch));
            }else{
                Console.Write(char.ToLower(ch));
            }
        }
    }
}
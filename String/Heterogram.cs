public class Heterogram{
    public static void Heterograms(){
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();
        int[] count = new int[26];
        bool flag = true;
        foreach (char c in input){
            int index = c-'a';
            if(count[index]>0){
                flag= false;
                break;
            }count[index]++;
        }
        flag= true;
    }
}
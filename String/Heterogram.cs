public class Heterogram{
    public static void Heterograms(){
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();
        int[] a = new int[26];
        bool flag = true;
        foreach (char c in input){
            int i = c-'a';
            if(a[i]>0){
                flag= false;
                break;
            }a[i]++;
        }
        if(flag==true){
            Console.WriteLine(true);
        }else{
            Console.WriteLine(false);
        }
    }
}
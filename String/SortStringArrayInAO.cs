public class SortStringArrayInAO{
    public static void SortStringArray(){
        Console.Write("Enter the text: ");
        string input = Console.ReadLine();
        char[] a;
        char ch;
        int l=input.Length;
        a = input.ToCharArray(0,l);
        for(int i=1;i<l; i++){
            for(int j=0; j<l-i; j++){
                if(a[j]>a[j+1]){
                    ch=a[j];
                    a[j]=a[j+1];
                    a[j+1]=ch;
                }
                
            }
        }
        foreach (var item in a)
                {
                    Console.Write("{0} ", item);
                }
    }
}
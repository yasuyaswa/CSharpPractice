public class Palindrome{
    public static bool pal(int n){
        int sum=0, r, temp;
        temp = n;
        while(n>0){
            r=n%10;
            sum=(sum*10)+r;
            n=n/10;
        }
        if(temp==sum){
            return true;
        }else{
            return false;
        }
    }
}
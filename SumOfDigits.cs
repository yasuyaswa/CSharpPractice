public class SumOfDigits{
    public static int SOD(int n){
        int sum=0, r;
        while(n>0){
            r=n%10;
            sum=sum+r;
            n=n/10;
        }
        return sum;
    }
}
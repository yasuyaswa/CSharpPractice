class PrimeNumberCheck{
    public static void PrimeCheck(int n){
        bool flag=false;
        for(int i=2;i<n;i++){
            if(n%i==0){  
                flag=false;
                Console.WriteLine("Not a Prime number");
                break;
            }else{
                flag=true;
            }
        }
        if(flag==true){
            Console.WriteLine("Prime number");
        }
    }
}
class PatternDownwardHalfPyramid{
    public static void PatterDown(int n){
        for(int i=1;i<=n;i++){
            for(int j=1;j<=i;j++){
                Console.Write("*"+" ");
            }
            Console.WriteLine();
        }
    }
}
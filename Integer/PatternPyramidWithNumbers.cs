class PatternPyramidWithNumbers{
    public static void PatterNumber(int n){
        for(int i=1;i<=n;i++){
            for(int j=1;j<=i;j++){
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
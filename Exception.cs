public class Exception{
    public static void excep(int n1, int n2){
        try{
            Console.WriteLine(n1/n2);
        }
        catch(System.Exception e){
            Console.WriteLine(e.Message);
        }
    }
    }
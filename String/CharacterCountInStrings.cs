public class CharacterCountInStrings{
    public static void CharacterCountInString(){
        //string e="1";
        // while(e!="0"){
        // Console.Write("Enter a String : ");
        string input = Console.ReadLine();
        input = input.Replace(" ", String.Empty).ToLower();
        while(input.Length>0){
            Console.Write(input[0]+" : ");
            int count=0;
            for(int i=0; i<input.Length; i++){
                if(input[0]==input[i]){
                    count++;
                }
            }
            Console.WriteLine(count);
            input=input.Replace(input[0].ToString(), String.Empty);
        /*second method
        var CharGroups = input.GroupBy(c=>c);
        foreach(var item in CharGroups){
            Console.WriteLine($"{item.Key} : {item.Count()}");
        }*/
        // }
        //     Console.WriteLine("\nEnter 0 for exit or any key to continue.");
        //     e=Console.ReadLine();
        }
    }
}
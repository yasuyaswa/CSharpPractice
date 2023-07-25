public class NumberInCharacters{
    public static void nic(){
        string n = Console.ReadLine();
        try {
            int i = 0;
            int num = int.Parse(n);
            while (i < n.Length) {
                switch (n[i]) {
                    case '0':
                        Console.Write("zero ");
                        break;
                    case '1':
                        Console.Write("one ");
                        break;
                    case '2':
                        Console.Write("two ");
                        break;
                    case '3':
                        Console.Write("three ");
                        break;
                    case '4':
                        Console.Write("four ");
                        break;
                    case '5':
                        Console.Write("five ");
                        break;
                    case '6':
                        Console.Write("six ");
                        break;
                    case '7':
                        Console.Write("seven ");
                        break;
                    case '8':
                        Console.Write("eight ");
                        break;
                    case '9':
                        Console.Write("nine ");
                        break;
                    default:
                        Console.Write("unknown number ");
                        break;
                }
                
                i++;
            }

        } catch (System.Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}
public class SortStringArrayInAO
{
    public static void SortStringArray()
    {
        Console.Write("Enter the text: ");
        string input = Console.ReadLine();
        char[] a = input.ToCharArray();
        int l = a.Length;

        for (int i = 0; i < l - 1; i++)
        {
            for (int j = 0; j < l - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    char temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        foreach (var item in a)
        {
            Console.Write(item + " ");
        }
    }
}
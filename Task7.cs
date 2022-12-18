namespace ConsoleApp1;

public class Task7
{
    public static void Main(string[] args)
    {
        Console.Write("please enter a  string:");
        var s = Console.ReadLine();
        if (s == null) return;
        var arr = s.ToCharArray();
        Array.Reverse(arr);
        var isPalindrome = true;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == arr[i]) continue;
            isPalindrome = false;
            break;
        }

        var result = isPalindrome == true
            ? "string is Palindrome"
            : "String is not Palindrome";
        Console.Write(result);
    }
}
namespace ConsoleApp1;
// last index of a 
public class Task3
{
    public static void Main(string[] args)
    {
        Console.Write("please enter a  string:");
        var s = Console.ReadLine();
        if (s == null) return;
        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != 'a') continue;
            Console.Write($"A's last index is {i}");
            break;
        }
    }
}
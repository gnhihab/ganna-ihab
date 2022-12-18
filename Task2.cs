namespace ConsoleApp1;
// count a
public class Task2
{
    public static void Main(string[] args)
    {
        Console.Write("please enter a  string:");
        var s = Console.ReadLine();
        if (s == null) return;
        var countA = 0;
        foreach (var c in s.ToLower())
        {
            if (c == 'a') countA++;
        }
        Console.Write($"A was repeated {countA} times");
    }
}
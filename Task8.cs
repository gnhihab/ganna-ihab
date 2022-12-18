namespace ConsoleApp1;

public class Task8
{
    public static void Main(string[] args)
    {
        Console.Write("please enter a  string:");
        var s = Console.ReadLine();
        if (s == null) return;
        var unique =new HashSet<char>(s);
        foreach (var c in unique)
        {
            Console.Write(c);
        }
    }
}
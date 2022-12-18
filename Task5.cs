namespace ConsoleApp1;
// add 0 after each a
public class Task5
{
    public static void Main(string[] args)
    {
        Console.Write("please enter a  string:");
        var s = Console.ReadLine();
        if (s == null) return;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != 'a') continue;
            s = s.Insert(i + 1, "0");
        }
        Console.Write(s);
    }
}
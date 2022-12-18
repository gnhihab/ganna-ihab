namespace ConsoleApp1;
// remove all a
public class Task4
{
    public static void Main(string[] args)
    {
        Console.Write("please enter a  string:");
        var s = Console.ReadLine();
        if (s == null) return;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != 'a')continue;
            s = s.Replace(s[i].ToString(), "");
        }
        Console.Write(s);
    }
}
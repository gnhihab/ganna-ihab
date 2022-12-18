namespace ConsoleApp1;

public class Task6
{
    public static void Main(string[] args)
    {
        Console.Write("please enter a  string:");
        var s = Console.ReadLine();
        if (s == null) return;
        var countForNonLiteral = 0;
        foreach (var c in s)
        {
            if (c>=65 && c<= 122)continue;
            countForNonLiteral++;
        }
        Console.Write($"there was {countForNonLiteral} non-literal character");
    }
}
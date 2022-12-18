namespace ConsoleApp1;

public class Task12
{
    public static void Main(string[] args)
    {
        Console.Write("please enter a  size of list:");
        var size = Convert.ToInt32(Console.ReadLine());
        var arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"please enter element {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        var average = arr.Average();
        var lessThanAvgCount = 0;
        
        foreach (var i in arr)
        {
            if (i >= average)continue;
            lessThanAvgCount++;
        }
        Console.WriteLine($"{average} is the average");
        Console.Write($"the numbers less than average are {lessThanAvgCount} number");
    }
}
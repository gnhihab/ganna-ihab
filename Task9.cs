namespace ConsoleApp1;

public class Task9
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
        var minDistance = double.PositiveInfinity;
        var num = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            var distance = average - arr[i];
            if (!(Math.Abs(distance) < minDistance)) continue;
            minDistance = Math.Abs(distance);
            num = arr[i];
        }
        
        Console.WriteLine($"{average} is the average ");
        Console.Write($"{num} is the nearest to the mean \n the difference is {minDistance} ");
    }
}
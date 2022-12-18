namespace ConsoleApp1;

public class Task10
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

        var min = arr[0];
        var max = arr[0];

        foreach (var i in arr)
        {
            if (i>max )
            {
                max = i;
            }

            if (i<min)
            {
                min = i;
            }
        }
        Console.WriteLine($"the min of the array is {min}");
        Console.WriteLine($"the max of the array is {max}");
    }
}